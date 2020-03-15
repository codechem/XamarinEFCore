using Entities;
using Microsoft.EntityFrameworkCore;

namespace XamarinEFCore.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ListItem> Items { get; set; }
        private const string DatabaseName = "myItems.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DatabaseName}");
        }
    }
}