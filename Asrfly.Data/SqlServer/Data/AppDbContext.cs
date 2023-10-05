using Asrfly.Core.Entities;
using Asrfly.Data.SqlServer.Data.Config;
using Microsoft.EntityFrameworkCore;

namespace Asrfly.Data.SqlServer.Data
{
    public class AppDbContext:DbContext
    {

        public DbSet<Categories> Categories { get; set; }
        public DbSet<SystemRecords> SystemRecords { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var conn = "Server = .; Database = AsrflyDatabase ; Integrated Security = SSPI; TrustServerCertificate = True;MultipleActiveResultSets=True";
            optionsBuilder.UseSqlServer(conn);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }
    }
}
