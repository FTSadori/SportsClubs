using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.Data.Configurations
{
    public sealed class ClubEntityConfiguration : IEntityTypeConfiguration<ClubEntity>
    {
        public void Configure(EntityTypeBuilder<ClubEntity> builder)
        {
            builder.ToTable("Clubs");
            builder.HasKey(e => e.ClubId);

            builder.HasMany(e => e.Awards)
                .WithOne(a => a.ClubEntity)
                .HasForeignKey(a => a.ClubId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.Members)
                .WithOne(m => m.ClubEntity)
                .HasForeignKey(m => m.ClubId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
