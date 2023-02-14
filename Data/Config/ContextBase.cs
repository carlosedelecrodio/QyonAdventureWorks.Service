using System;
using System.Collections.Generic;
using System.Text;
using AdventureWorks.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Data.Config
{
    public class ContextBase : DbContext
    {
        public ContextBase() { }

        public ContextBase(DbContextOptions<ContextBase> options) : base(options) { }

        public DbSet<Competitor> Competitors { get; set; }
        public DbSet<RaceHistory> RaceHistory { get; set; }
        public DbSet<RaceTrack> RaceTrack { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(GetStringConnect());
                base.OnConfiguring(optionsBuilder);
            }
        }

        public string GetStringConnect()
        {
            return "User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=QyonAdventureWorks;Connection Lifetime=0;";
        }
    }
}
