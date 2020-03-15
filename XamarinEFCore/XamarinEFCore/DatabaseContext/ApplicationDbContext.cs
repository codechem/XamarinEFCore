using System;
using System.IO;
using Entities;
using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;

namespace XamarinEFCore.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ListItem> Items { get; set; }
        private const string DatabaseName = "myItems.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String databasePath;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..",
                        "Library", DatabaseName);
                    break;
                case Device.Android:
                    databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                        DatabaseName);
                    break;
                default:
                    throw new NotImplementedException("Platform not supported");
            }

            optionsBuilder.UseSqlite($"Filename={databasePath}");
        }
    }
}