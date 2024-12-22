using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations;

public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.IsDeleted).IsRequired().HasDefaultValue(false);
        builder.Property(c => c.UpdateUserId).IsRequired();
        builder.Property(c => c.UpdatedDate).IsRequired();

        builder.Property(x=>x.CustomerId).IsRequired();
        builder.Property(x=>x.Plate).HasMaxLength(10).IsRequired();
        builder.Property(x=>x.SasiNo).HasMaxLength(20).IsRequired();
        builder.Property(x=>x.Color).HasMaxLength(20).IsRequired();
        builder.Property(x=>x.Year).HasMaxLength(10).IsRequired();
        builder.Property(x=>x.Marka).HasMaxLength(150).IsRequired();
        builder.Property(x=>x.Model).HasMaxLength(150).IsRequired();

        #region ARAÇ BAKIM İLİŞKİSİ
        builder.HasOne(bl => bl.Customer)
            .WithMany(bl => bl.Vehicles)
            .HasForeignKey(bl => bl.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(bl => bl.Bakims)
            .WithOne(bl => bl.Vehicle)
            .HasForeignKey(bl => bl.VehicleId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(bl => bl.IsEmris)
            .WithOne(bl => bl.Vehicle)
            .HasForeignKey(bl => bl.VehicleId)
            .OnDelete(DeleteBehavior.Cascade);
        #endregion
        builder.ToTable("Vehicles");
    }
}
