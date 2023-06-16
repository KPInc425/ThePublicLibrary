using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using Langwish.Infrastructure;
using Langwish.Models;
using Microsoft.EntityFrameworkCore;

namespace Langwish.Services
{
    public class MapFileCreateService
    {
        Dictionary<string, long> _localizeDict = new Dictionary<string, long>();
        LangwishDbContext _dbContext;
        public MapFileCreateService(LangwishDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public void ScanDir()
        {
            var path = @"C:\code\2021\Rdy6a\repo\AddToMeetingb\src\";
            string[] extensions = { ".cs", ".razor", ".html" };
            foreach (string file in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(rs => extensions.Any(ext => ext == Path.GetExtension(rs)) && !rs.EndsWith(".g.cs")))
            {
                var fileInfo = new FileInfo(file);
                FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                if (fs.CanRead && fileInfo.Length < 100000)
                {

                    var fileContents = System.IO.File.ReadAllText(file);
                    if (fileContents.Contains("Localize["))
                    {
                        try
                        {
                            var folderName = System.IO.Path.GetDirectoryName(file);
                            var dbFolderWatcher = _dbContext.FolderWatchers.FirstOrDefault(rs => rs.FolderName == folderName);
                            LangwishWord dbLangwishWord = null;
                            ICollection<LangwishWord> localWords = new List<LangwishWord>();

                            if (dbFolderWatcher == null)
                            {
                                dbFolderWatcher = new FolderWatcher
                                {
                                    FolderName = folderName,
                                    FoundModulesCt = 1,
                                    FoundEntriesCt = 1,
                                    FoundEntriesUniqueCt = 1,
                                    ProjectRootPath = FindRootPathOfBlazorProject(file)
                                };
                                _dbContext.FolderWatchers.Add(dbFolderWatcher);
                            }
                            // lets go grab all the occurances of this localize in the file
                            var indexOfNextOccurance = fileContents.IndexOf("Localize[");
                            while (indexOfNextOccurance > -1)
                            {
                                var readCount = fileContents.IndexOf("]", indexOfNextOccurance) - "Localize[".Length - indexOfNextOccurance - 2;
                                var startIndex = indexOfNextOccurance + "Localize[".Length;
                                var localizeValue = fileContents.Substring(startIndex + 1, readCount);

                                if (_localizeDict.ContainsKey(localizeValue))
                                {
                                    _localizeDict[localizeValue] = _localizeDict[localizeValue]++;
                                }
                                else
                                {
                                    _localizeDict.Add(localizeValue, 1);
                                }

                                dbLangwishWord = _dbContext.LangwishWords.FirstOrDefault(rs => rs.TranslateText == localizeValue);
                                if (dbLangwishWord == null)
                                {
                                    dbLangwishWord = new LangwishWord
                                    {
                                        TranslateText = localizeValue
                                    };
                                    _dbContext.LangwishWords.Add(dbLangwishWord);
                                }
                                localWords.Add(dbLangwishWord);

                                // continue to check the rest of the text until we have them all
                                indexOfNextOccurance = fileContents.IndexOf("Localize[", indexOfNextOccurance + 1);
                            }
                            var dbFileWatcher =
                                _dbContext.FileWatchers
                                .Include(rs => rs.LangwishWordInFiles)
                                .Where(rs => rs.FileNameWithFullPath == file)
                                .FirstOrDefault();

                            if (dbFileWatcher == null)
                            {
                                dbFileWatcher = new FileWatcher
                                {
                                    FolderWatcher = dbFolderWatcher,
                                    FileNameWithFullPath = file,
                                    FileName = System.IO.Path.GetFileName(file),
                                    FileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(file)
                                };

                                _dbContext.FileWatchers.Add(dbFileWatcher);
                            }

                            foreach (var lword in localWords)
                            {
                                var langwishWordInFile = dbFileWatcher.LangwishWordInFiles.FirstOrDefault(rs => rs.LangwishWord.TranslateText == lword.TranslateText);
                                if (langwishWordInFile == null)
                                {
                                    _dbContext.LangwishWordInFiles.Add(new LangwishWordInFile { FileWatcher = dbFileWatcher, LangwishWord = lword });
                                }
                            }

                            _dbContext.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            var b = ex.Message;
                        }
                        finally
                        {
                            fileInfo = null;
                            fs = null;
                        }
                    }
                }
            }
        }

        private string FindRootPathOfBlazorProject(string fileToStartWith)
        {
            var found = false;
            var parent = System.IO.Directory.GetParent(fileToStartWith);

            while (!found || parent != null)
            {
                if (parent.GetDirectories().Count(rs => rs.Name == "wwwroot") > 0)
                {
                    found = true;
                    return parent.FullName;
                }

                parent = parent.Parent;
            }
            return "";
        }
        public void CreateFile() { }

        private IEnumerable<string> GetFiles(string path)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(path);
            while (queue.Count > 0)
            {
                path = queue.Dequeue();
                try
                {
                    foreach (string subDir in Directory.GetDirectories(path))
                    {
                        queue.Enqueue(subDir);
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
                string[] files = null;
                try
                {
                    files = Directory.GetFiles(path);
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex);
                }
                if (files != null)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        yield return files[i];
                    }
                }
            }
        }
    }
}