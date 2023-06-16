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
    public class DatabaseService
    {
        Dictionary<string, long> _localizeDict = new Dictionary<string, long>();
        LangwishDbContext _dbContext;
        public DatabaseService(LangwishDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public void ClearData()
        {
            this._dbContext.Database.ExecuteSqlRaw("DELETE FROM LangwishWordInFiles");
            this._dbContext.Database.ExecuteSqlRaw("DELETE FROM LangwishRuns");
            this._dbContext.Database.ExecuteSqlRaw("DELETE FROM LangwishWords");
            this._dbContext.Database.ExecuteSqlRaw("DELETE FROM FileWatchers");
            this._dbContext.Database.ExecuteSqlRaw("DELETE FROM FolderWatchers");
        }
    }
}