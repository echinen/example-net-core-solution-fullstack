using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Value> Values { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
            .HasData(
                new Value { ID = 1, Name = "Test 111" },
                new Value { ID = 2, Name = "Test 222" },
                new Value { ID = 3, Name = "Test 333" }
            );
        }
    }
}
