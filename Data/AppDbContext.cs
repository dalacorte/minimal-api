﻿using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=app.dv;Cache=Shared");
    }
}
