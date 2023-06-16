// This file is now under code-gen control, do not touch, will be regenerated frequenly
using System;
using System.Linq;
using System.Text.RegularExpressions;
using Langwish.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
namespace Langwish.Infrastructure
{
    public partial class LangwishDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) { optionsBuilder.UseSqlite("Data Source=Langwish.db"); }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LangwishWordInFile>()
            .HasKey(rs => new { rs.LangwishWordId, rs.FileWatcherId });
        }
    }
}

