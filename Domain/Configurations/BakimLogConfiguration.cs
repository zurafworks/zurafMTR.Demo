using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations;

public class BakimLogConfiguration : IEntityTypeConfiguration<BakimLog>
{
    public void Configure(EntityTypeBuilder<BakimLog> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.IsDeleted).IsRequired().HasDefaultValue(false);
        builder.Property(c => c.UpdateUserId).IsRequired();
        builder.Property(c => c.UpdatedDate).IsRequired();

        builder.Property(bl => bl.VehicleId).IsRequired();
        builder.Property(bl => bl.Summary).HasMaxLength(500).IsRequired();
        #region ARAÇ BAKIM İLİŞKİSİ
        builder.HasOne(bl => bl.Vehicle)
            .WithMany(bl => bl.Bakims)
            .HasForeignKey(bl => bl.VehicleId)
            .OnDelete(DeleteBehavior.Cascade);
        #endregion
        builder.ToTable("BakimLogs");
    }
}
