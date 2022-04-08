using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevChallenge.Models;

namespace DevChallenge.DAL
{
    public class DBInteractor : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlite(@"Data Source = challenge.db;");
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
            new Employee(1, "Kindson", "Munonye", "Budapest", "2018-03-29"),
            new Employee(2, "Oleander", "Yuba", "Nigeria", "2018-03-29")
            );
        }
    }
}
