using Domain;
using Microsoft.EntityFrameworkCore;
using ORMtest.Domain;


namespace Data
{
    public class DataContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Product> Products { get; set; }
        public string DbPath { get; }

        public DataContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "ORMtest.db");
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    }
}