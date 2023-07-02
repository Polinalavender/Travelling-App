using System;
using Microsoft.EntityFrameworkCore;
using mauiMap.Models; 

namespace mauiMap
{
	public class PinDbContext:DbContext
	{
        private readonly string databasePath;

        public DbSet<Pin> Pins { get; set; }

        public PinDbContext(string databasePath)
        {
            this.databasePath = databasePath;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

    }
}

