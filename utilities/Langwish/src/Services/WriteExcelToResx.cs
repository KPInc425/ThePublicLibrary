using System.Threading;
using System.Net.Security;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using Langwish.Infrastructure;
using Langwish.Models;
using Microsoft.EntityFrameworkCore;

namespace Langwish.Services
{
    public class WriteExcelToResx
    {
        LangwishDbContext _dbContext;
        public WriteExcelToResx(LangwishDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void CreateResxFiles()
        {
            var curDir = Path.GetDirectoryName(Environment.CurrentDirectory);
            var fileName = Path.Combine(curDir, "Langwish.xlsx");

            var dbFileWatchers = _dbContext
                .FileWatchers
                .Include(rs => rs.LangwishWordInFiles)
                .ThenInclude(rss => rss.LangwishWord)
                .Where(rs => rs.Id > 0);

            var file = new FileInfo(fileName);
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var langwishEx = new OfficeOpenXml.ExcelPackage(file))
            {
                foreach (var dbFile in dbFileWatchers.ToList())
                {
                    var shortName = dbFile.FileNameWithoutExtension.Length <= 31 ? dbFile.FileNameWithoutExtension : dbFile.FileNameWithoutExtension.Substring(0, 31);

                    var worksheet = langwishEx.Workbook.Worksheets.FirstOrDefault(rs => rs.Name == shortName);
                    if (worksheet == null)
                    {
                        throw new Exception("didn't expect missing worksheets, try re-running previous step");
                    }

                    Dictionary<string, int> pivotedAnswers = new Dictionary<string, int>();

                    // leave top for headers
                    var x = 2;

                    string rowVal = worksheet.GetValue(x, 1) == null ? "" : worksheet.GetValue(x, 1).ToString();
                    string rowAns = worksheet.GetValue(x, 2) == null ? "" : worksheet.GetValue(x, 2).ToString();

                    while (rowVal != "")
                    {
                        pivotedAnswers.Add(rowVal, x);
                        x++;
                        rowVal = worksheet.GetValue(x, 1) == null ? "" : worksheet.GetValue(x, 1).ToString();
                        rowAns = worksheet.GetValue(x, 2) == null ? "" : worksheet.GetValue(x, 2).ToString();
                    }

                    // time to pivot out all the languages and language files, woo-hoo

                    var usefulColumnCount = 1;
                    var usefulColumnTestValue = "-1";
                    var languages = new Dictionary<string, int>();
                    while (usefulColumnTestValue != "")
                    {
                        usefulColumnCount++;
                        usefulColumnTestValue = worksheet.GetValue(1, usefulColumnCount) != null ? worksheet.GetValue(1, usefulColumnCount).ToString() : "";
                        if (usefulColumnTestValue != "")
                        {
                            languages.Add(usefulColumnTestValue.ToLower(), usefulColumnCount);
                        }
                    }

                    foreach (var language in languages)
                    {

                        /*  if (!System.IO.Directory.Exists(System.IO.Path.Join(dbFile.FolderWatcher.ProjectRootPath, "Shared", "Resources")))
                         {
                             System.IO.Directory.CreateDirectory(System.IO.Path.Join(dbFile.FolderWatcher.ProjectRootPath, "Shared", "Resources"));
                         } */
                        /* if (System.IO.File.Exists(System.IO.Path.Join(dbFile.FolderWatcher.ProjectRootPath, "Shared", "Resources", dbFile.FileNameWithoutExtension + "." + language.Key + ".resx")))
                        {
                            System.IO.File.Delete(System.IO.Path.Join(dbFile.FolderWatcher.ProjectRootPath, "Shared", "Resources", dbFile.FileNameWithoutExtension + "." + language.Key + ".resx"));
                        } */

                        if (System.IO.File.Exists(System.IO.Path.Join(System.IO.Path.GetDirectoryName(dbFile.FileNameWithFullPath), dbFile.FileNameWithoutExtension + "." + language.Key + ".resx")))
                        {
                            System.IO.File.Delete(System.IO.Path.Join(System.IO.Path.GetDirectoryName(dbFile.FileNameWithFullPath), dbFile.FileNameWithoutExtension + "." + language.Key + ".resx"));
                            if (language.Key.ToLower() == "en")
                            {
                                if (System.IO.File.Exists(System.IO.Path.Join(System.IO.Path.GetDirectoryName(dbFile.FileNameWithFullPath), dbFile.FileNameWithoutExtension + ".resx")))
                                {
                                    System.IO.File.Delete(System.IO.Path.Join(System.IO.Path.GetDirectoryName(dbFile.FileNameWithFullPath), dbFile.FileNameWithoutExtension + ".resx"));
                                }
                            }
                        }

                        var fileContentTemplate = System.IO.File.ReadAllText(System.IO.Path.Join(curDir, "resx_xml_template.txt"));
                        var fileSegmentTemplate = System.IO.File.ReadAllText(System.IO.Path.Join(curDir, "resx_xml_template_segment.txt"));
                        var buffOut = new StringBuilder();

                        foreach (var word in dbFile.LangwishWordInFiles)
                        {
                            int langRow = pivotedAnswers.FirstOrDefault(rs => rs.Key == word.LangwishWord.TranslateText).Value;
                            int langCol = language.Value;
                            string langValue = System.Web.HttpUtility.HtmlEncode(worksheet.GetValue(langRow, langCol) != null ? worksheet.GetValue(langRow, langCol).ToString() : "");
                            buffOut.AppendLine(String.Format(fileSegmentTemplate, word.LangwishWord.TranslateText, langValue));
                            // resxFile.AddResource(word.LangwishWord.TranslateText, pivotedAnswers.GetValueOrDefault(word.LangwishWord.TranslateText));
                        }
                        System.IO.File.WriteAllText(System.IO.Path.Join(System.IO.Path.GetDirectoryName(dbFile.FileNameWithFullPath), dbFile.FileNameWithoutExtension + "." + language.Key + ".resx"), String.Format(fileContentTemplate, buffOut.ToString()));
                        if (language.Key.ToLower() == "en")
                        {
                            System.IO.File.WriteAllText(System.IO.Path.Join(System.IO.Path.GetDirectoryName(dbFile.FileNameWithFullPath), dbFile.FileNameWithoutExtension + ".resx"), String.Format(fileContentTemplate, buffOut.ToString()));
                        }

                        // see if we can help the watcher system not freak from so many changes so quickly
                        Thread.Sleep(200);
                        //System.IO.File.WriteAllText(System.IO.Path.Join(dbFile.FolderWatcher.ProjectRootPath, "Shared", "Resources", dbFile.FileNameWithoutExtension + "." + language.Key + ".resx"), String.Format(fileContentTemplate, buffOut.ToString()));

                        /* if (language.Key.ToLower() == "en")
                        {
                            System.IO.File.WriteAllText(System.IO.Path.Join(dbFile.FolderWatcher.ProjectRootPath, "Shared", "Resources", dbFile.FileNameWithoutExtension + ".resx"), String.Format(fileContentTemplate, buffOut.ToString()));
                        } */
                    }
                }
            }
        }
    }
}