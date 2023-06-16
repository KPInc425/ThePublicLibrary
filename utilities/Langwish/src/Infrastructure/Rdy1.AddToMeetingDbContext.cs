// This file is now under code-gen control, do not touch, will be regenerated frequenly
using System;
using System.Linq;
using System.Text.RegularExpressions;
using Langwish.Models;
using Microsoft.EntityFrameworkCore;
namespace Langwish.Infrastructure {
    public partial class LangwishDbContext : DbContext {
        public virtual DbSet<FolderWatcher> FolderWatchers { get; set; }
        public virtual DbSet<FileWatcher> FileWatchers { get; set; }
        public virtual DbSet<LangwishRun> LangwishRuns { get; set; }
        public virtual DbSet<LangwishWord> LangwishWords { get; set; }
        public virtual DbSet<LangwishWordInFile> LangwishWordInFiles { get; set; }

        public LangwishDbContext (DbContextOptions options) : base (options) { }
    }
}
