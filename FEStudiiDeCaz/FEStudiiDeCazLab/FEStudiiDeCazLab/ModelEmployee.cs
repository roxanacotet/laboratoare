﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace FEStudiiDeCazLab
{
    class ModelEmployee : DbContext
    {
       public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
                .Map<FullTimeEmployee>(m => m.Requires("EmployeeType")
                .HasValue(1))
                .Map<HourlyEmployee>(m => m.Requires("EmployeeType")
                .HasValue(2));
        }
    }
}
