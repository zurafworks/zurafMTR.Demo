using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations;

public class IsEmriConfiguration : IEntityTypeConfiguration<IsEmri>
{
    public void Configure(EntityTypeBuilder<IsEmri> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.IsDeleted).IsRequired().HasDefaultValue(false);
        builder.Property(c => c.UpdateUserId).IsRequired();
        builder.Property(c => c.UpdatedDate).IsRequired();

        builder.Property(x=>x.StartDate).IsRequired();
        builder.Property(x=>x.EndDate).IsRequired();
        builder.Property(x=>x.Status).IsRequired();
        builder.Property(x=>x.TotalCost).IsRequired();

        #region İŞ EMRİ İLİŞKİLERİ
        builder.HasMany(bl => bl.IsEmriDetails)
            .WithOne(bl => bl.IsEmri)
            .HasForeignKey(bl => bl.IsEmriId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(bl => bl.Reports)
            .WithOne(bl => bl.IsEmri)
            .HasForeignKey(bl => bl.IsEmriId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(bl => bl.Vehicle)
            .WithMany(bl => bl.IsEmris)
            .HasForeignKey(bl => bl.VehicleId)
            .OnDelete(DeleteBehavior.Cascade);
        #endregion
        builder.ToTable("IsEmris");
    }
}
