using DemoEFCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEFCoreApp.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }


        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = demodb.sqlite");
            optionsBuilder.LogTo(System.Console.WriteLine, LogLevel.Information);
        }

    }
}
