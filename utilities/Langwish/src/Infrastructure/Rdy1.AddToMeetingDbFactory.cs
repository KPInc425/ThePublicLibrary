using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Langwish.Infrastructure;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace AddToMeeting.Infrastructure
{
    public class LangwishDbFactory : IDesignTimeDbContextFactory<LangwishDbContext>
    {
        public LangwishDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LangwishDbContext>();
            optionsBuilder.UseSqlite("Data Source=Langwish.db");
            return new LangwishDbContext(optionsBuilder.Options);
        }

    }
}
