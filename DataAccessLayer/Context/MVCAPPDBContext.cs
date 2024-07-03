using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Context
{
    public class MVCAPPDBContext : DbContext
    {
        public MVCAPPDBContext(DbContextOptions<MVCAPPDBContext> options) :base(options) 
        {

        
        }
      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = . ; Database = MVCApp; Trusted_connection =True");

            base.OnConfiguring(optionsBuilder);
        }*/

        public DbSet<Department> Derpartments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
