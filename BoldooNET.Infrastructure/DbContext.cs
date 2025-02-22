using Microsoft.EntityFrameworkCore;
using BoldooNET.Domain.Models;

namespace BoldooNET.Infrastructure {
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext {
        public DbContext() { 
        
        }

        public DbContext(DbContextOptions<DbContext> options) : base(options) {

        }

        public virtual DbSet<Model> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(sqlServerOptionsAction: options => options.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

        }
    }
}
