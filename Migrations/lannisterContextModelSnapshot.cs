﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RateThePlate.Models;

namespace RateThePlate.Migrations
{
    [DbContext(typeof(lannisterContext))]
    partial class lannisterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("lannisteruser")
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RateThePlate.Models.Badge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Badge","dbo");
                });

            modelBuilder.Entity("RateThePlate.Models.CarPlate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasColumnName("plateNumber")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("CarPlate","dbo");
                });

            modelBuilder.Entity("RateThePlate.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BadgeId");

                    b.Property<int>("CarPlateId");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("Id");

                    b.HasIndex("BadgeId");

                    b.HasIndex("CarPlateId");

                    b.ToTable("Feedback","dbo");
                });

            modelBuilder.Entity("RateThePlate.Models.Feedback", b =>
                {
                    b.HasOne("RateThePlate.Models.Badge", "Badge")
                        .WithMany("Feedback")
                        .HasForeignKey("BadgeId")
                        .HasConstraintName("FK_Feedback_Badge1");

                    b.HasOne("RateThePlate.Models.CarPlate", "CarPlate")
                        .WithMany("Feedback")
                        .HasForeignKey("CarPlateId")
                        .HasConstraintName("FK_Feedback_CarPlate1");
                });
#pragma warning restore 612, 618
        }
    }
}
