using HomeWork21.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork21.ContextFolder
{
    public class DataContext : DbContext
    {
        public DbSet<Record> Records { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;
                DataBase=Recordsbook;
                Trusted_Connection=True;"
                );
        }
    }
}
