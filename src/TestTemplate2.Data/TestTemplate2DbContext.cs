using MassTransit;
using Microsoft.EntityFrameworkCore;
using TestTemplate2.Core.Entities;

namespace TestTemplate2.Data
{
    public class TestTemplate2DbContext : DbContext
    {
        public TestTemplate2DbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Foo> Foos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddInboxStateEntity();
            modelBuilder.AddOutboxMessageEntity();
            modelBuilder.AddOutboxStateEntity();
        }
    }
}
