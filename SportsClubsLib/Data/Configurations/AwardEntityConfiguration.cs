using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.Data.Configurations
{
    internal class AwardEntityConfiguration : IEntityTypeConfiguration<AwardEntity>
    {
        public void Configure(EntityTypeBuilder<AwardEntity> builder)
        {
            builder.ToTable("Awards");
            builder.HasKey(e => e.AwardId);
        }
    }
}
