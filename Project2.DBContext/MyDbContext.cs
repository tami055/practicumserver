using Microsoft.EntityFrameworkCore;
using project2;
using project2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.DBContext
{
    public class MyDbContext : DbContext, Icontext
    {
        public DbSet<User> user { get ; set ; }
        public DbSet<Child> child { get ; set ; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\\MSSQLLocalDB;Database=TDdatabase;Trusted_connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelbulider)
        {
            base.OnModelCreating(modelbulider);
        }

    }
}
