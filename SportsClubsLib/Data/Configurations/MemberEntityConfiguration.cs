using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsClubsLib.Data.Entities;

namespace SportsClubsLib.Data.Configurations
{
    public sealed class MemberEntityConfiguration : IEntityTypeConfiguration<MemberEntity>
    {
        public void Configure(EntityTypeBuilder<MemberEntity> builder)
        {
            builder.ToTable("Members");
            builder.HasKey(e => e.MemberId);
        }
    }
}
