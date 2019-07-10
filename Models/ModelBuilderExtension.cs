using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RateThePlate.Models
{
    static class ModelBuilderExtension
    {
        public static void Populate(this ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "lannisteruser");

            modelBuilder.Entity<Badge>(entity =>
            {
                entity.ToTable("Badge", "dbo");

                entity.Property(e => e.Rating)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarPlate>(entity =>
            {
                entity.ToTable("CarPlate", "dbo");

                entity.Property(e => e.PlateNumber)
                    .IsRequired()
                    .HasColumnName("plateNumber")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback", "dbo");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Badge)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.BadgeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_Badge1");

                entity.HasOne(d => d.CarPlate)
                    .WithMany(p => p.Feedback)
                    .HasForeignKey(d => d.CarPlateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_CarPlate1");
            });
        }
    }
}
