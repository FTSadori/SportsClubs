using Microsoft.EntityFrameworkCore;
using SportsClubsLib.Data.Entities;
using System.Reflection;

namespace SportsClubsLib.Data
{
    public sealed class SportsClubsDbContext : DbContext
    {
        public DbSet<SportEntity> Sports { get; set; }
        public DbSet<ClubEntity> Clubs { get; set; }
        public DbSet<MemberEntity> Members { get; set; }
        public DbSet<AwardEntity> Awards { get; set; }

        public SportsClubsDbContext(DbContextOptions<SportsClubsDbContext> options): base(options) 
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
