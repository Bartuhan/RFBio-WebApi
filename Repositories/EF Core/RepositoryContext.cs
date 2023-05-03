using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EF_Core.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EF_Core
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext( DbContextOptions options ) : base( options ){ }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeCard> EmployeeCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfig());   // Base Data Yaratmak İçin Override Metodu
            modelBuilder.ApplyConfiguration(new EmployeeCardConfig());
        }
    }
}
