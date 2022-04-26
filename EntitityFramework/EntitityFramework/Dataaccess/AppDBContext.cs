using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitityFramework.Dataaccess
{
    class AppDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6EQ5FGI; Database=CompanyDB;Integrated Security=true;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
