using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevChallenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace DevChallenge.DAL
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public ApplicationDBContext() : base()
        {
        }
    }
}