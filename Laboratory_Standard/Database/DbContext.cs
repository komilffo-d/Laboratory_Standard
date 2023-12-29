using Lab_9.Database.Entities;
using Laboratory_Standard.Database.Entities;
using Microsoft.EntityFrameworkCore;
namespace Laboratory_Standard
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
/*            Database.EnsureDeleted();*/
            Database.EnsureCreated();
        }

        public DbSet<ExpertDb> Experts { get; set; }
        public DbSet<AccountDb> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExpertDb>().Property(t => t.Id).UseMySqlIdentityColumn<int>();
            modelBuilder.Entity<AccountDb>().Property(t => t.Id).UseMySqlIdentityColumn<int>();

            new DbInitializer(modelBuilder).Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
