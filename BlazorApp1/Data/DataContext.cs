﻿using BlazorApp1.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        public DbSet<Game> Games { get; set; }
   
    }
}
