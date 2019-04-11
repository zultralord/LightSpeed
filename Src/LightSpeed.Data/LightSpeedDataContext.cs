﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LightSpeed.Data.Models;

namespace LightSpeed.Data
{
    public class LightSpeedDataContext : DbContext
    {
        public LightSpeedDataContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=appdata.db");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
