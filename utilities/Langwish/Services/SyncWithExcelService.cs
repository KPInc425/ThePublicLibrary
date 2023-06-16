using System.Net.Security;
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
    public class SyncWithExcelService
    {
        LangwishDbContext _dbContext;
        public SyncWithExcelService(LangwishDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void SyncWithExcel()
        {
            var curDir = Path.GetDirectoryName(Environment.CurrentDirectory);
            var fileName = Path.Combine(curDir, "Langwish.xlsx");

            var dbFileWatchers = _dbContext
                .FileWatchers
                .Include(rs => rs.LangwishWordInFiles)
                .ThenInclude(rss => rss.LangwishWord)
                .Where(rs => rs.Id > 0);

            var fileIsLocked = true;
            try
            {
                var testFile = File.OpenWrite(fileName);
                fileIsLocked = !testFile.CanWrite;
                testFile.Close();
                testFile.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            if (!fileIsLocked)
            {
                var file = new FileInfo(fileName);
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var langwishEx = new OfficeOpenXml.ExcelPackage(file))
                {
                    foreach (var dbFile in dbFileWatchers.ToList())
                    {
                        var shortName = dbFile.FileNameWithoutExtension.Length <= 31 ? dbFile.FileNameWithoutExtension : dbFile.FileNameWithoutExtension.Substring(0, 31);
                        var rowCursor = 0;
                        var worksheet = langwishEx.Workbook.Worksheets.FirstOrDefault(rs => rs.Name == shortName);
                        if (worksheet == null)
                        {
                            Console.WriteLine($"Adding {shortName} worksheet");
                            worksheet = langwishEx.Workbook.Worksheets.Add(shortName);
                            worksheet.SetValue(1, 1, "WORD");
                            worksheet.SetValue(1, 2, "EN");
                            worksheet.SetValue(1, 3, "FR");
                            worksheet.SetValue(1, 4, "JA");
                            worksheet.SetValue(1, 5, "TA");
                        }

                        Dictionary<string, long> pivotedHeaders = new Dictionary<string, long>();

                        // leave top for headers
                        var x = 2;

                        string rowVal = worksheet.GetValue(x, 1) == null ? "" : worksheet.GetValue(x, 1).ToString();
                        while (rowVal != "")
                        {
                            pivotedHeaders.Add(rowVal, x);
                            x++;
                            rowVal = worksheet.GetValue(x, 1) == null ? "" : worksheet.GetValue(x, 1).ToString();
                        }   // Save to file
                        rowCursor = pivotedHeaders.Count + 2;
                        foreach (var word in dbFile.LangwishWordInFiles)
                        {
                            if (!pivotedHeaders.ContainsKey(word.LangwishWord.TranslateText))
                            {
                                worksheet.SetValue(rowCursor++, 1, word.LangwishWord.TranslateText);
                            }
                        }

                        langwishEx.Save();
                    }
                }
            }
            else
            {
                Console.WriteLine("Could not lock the excel file for edit, pls close this file and try again.");
            }
        }
    }
}