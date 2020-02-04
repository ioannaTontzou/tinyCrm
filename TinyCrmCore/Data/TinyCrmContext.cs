﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TinyCrm.Core.Model;

namespace TinyCrm.Core.Data
{
   public  class TinyCrmContext : DbContext
    {
        private readonly string connectionString_;

        public TinyCrmContext():base()
        {
            connectionString_ = "Server=localhost;Database = tinycrm; User Id= sa;Password=QWE123!@#";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /* base.OnConfiguring(optionsBuilder);
             optionsBuilder.UseSqlServer("Server=localhost;Database=tinycrm;Integrated Security=True;");
            */
            optionsBuilder.UseSqlServer(connectionString_);

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .Entity<Product>()
                .ToTable("Product");
        }
    }
}
