﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsClubsLib.Data;

#nullable disable

namespace SportsClubsLib.Migrations
{
    [DbContext(typeof(SportsClubsDbContext))]
    [Migration("20230918133847_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SportsClubsLib.Data.Entities.AwardEntity", b =>
                {
                    b.Property<int>("AwardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AwardId"));

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("AwardId");

                    b.HasIndex("ClubId");

                    b.ToTable("Awards", (string)null);
                });

            modelBuilder.Entity("SportsClubsLib.Data.Entities.ClubEntity", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClubId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SportId")
                        .HasColumnType("int");

                    b.HasKey("ClubId");

                    b.HasIndex("SportId");

                    b.ToTable("Clubs", (string)null);
                });

            modelBuilder.Entity("SportsClubsLib.Data.Entities.MemberEntity", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberId"));

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberId");

                    b.HasIndex("ClubId");

                    b.ToTable("Members", (string)null);
                });

            modelBuilder.Entity("SportsClubsLib.Data.Entities.SportEntity", b =>
                {
                    b.Property<int>("SportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SportId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportId");

                    b.ToTable("Sports", (string)null);
                });

            modelBuilder.Entity("SportsClubsLib.Data.Entities.AwardEntity", b =>
                {
                    b.HasOne("SportsClubsLib.Data.Entities.ClubEntity", "ClubEntity")
                        .WithMany("Awards")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClubEntity");
                });

            modelBuilder.Entity("SportsClubsLib.Data.Entities.ClubEntity", b =>
                {
                    b.HasOne("SportsClubsLib.Data.Entities.SportEntity", "SportEntity")
                        .WithMany("Clubs")
                        .HasForeignKey("SportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SportEntity");
                });

            modelBuilder.Entity("SportsClubsLib.Data.Entities.MemberEntity", b =>
                {
                    b.HasOne("SportsClubsLib.Data.Entities.ClubEntity", "ClubEntity")
                        .WithMany("Members")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClubEntity");
                });

            modelBuilder.Entity("SportsClubsLib.Data.Entities.ClubEntity", b =>
                {
                    b.Navigation("Awards");

                    b.Navigation("Members");
                });

            modelBuilder.Entity("SportsClubsLib.Data.Entities.SportEntity", b =>
                {
                    b.Navigation("Clubs");
                });
#pragma warning restore 612, 618
        }
    }
}
