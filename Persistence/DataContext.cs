using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        // this will create a table in our database referencing from the value class in the domain
        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
                .HasData(
                    new Value {Id = 1, Name = "Value 101"},
                     new Value {Id = 2, Name = "Value 102"},
                      new Value {Id = 3, Name = "Value 103"}
                );
        }
        
        
    }
}
