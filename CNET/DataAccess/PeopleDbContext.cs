using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DataAccess
{
    public class PeopleDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Contract> Contracts { get; set; }


        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={GetDbPath()}");
        }

        private string GetDbPath()
        {
            //return @"C:\PROJECTS\skoleni\people.db";

            var folder = Environment.SpecialFolder.LocalApplicationData;
            var local_folder = Environment.GetFolderPath(folder);
            var path = Path.Join(local_folder, "PeopleDb");
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return Path.Join(path, "people.db");
        }
    }
}
