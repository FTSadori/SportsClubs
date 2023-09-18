using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.Data.Configurations
{
    public sealed class SportEntityConfiguration : IEntityTypeConfiguration<SportEntity>
    {
        public void Configure(EntityTypeBuilder<SportEntity> builder)
        {
            builder.ToTable("Sports");
            builder.HasKey(e => e.SportId);

            builder.HasMany(e => e.Clubs)
                .WithOne(c => c.SportEntity)
                .HasForeignKey(c => c.SportId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
