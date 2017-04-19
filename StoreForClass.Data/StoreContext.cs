﻿using StoreForClass.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreForClass.Data
{
   public class StoreContext : DbContext
    {
        public StoreContext() : base("StoreContext")
        {
        }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<Purchase> Purchases { get; set; }
            public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
    }
}
