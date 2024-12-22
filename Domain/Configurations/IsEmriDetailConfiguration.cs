using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations;

public class IsEmriDetailConfiguration : IEntityTypeConfiguration<IsEmriDetail>
{
    public void Configure(EntityTypeBuilder<IsEmriDetail> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.IsDeleted).IsRequired().HasDefaultValue(false);
        builder.Property(c => c.UpdateUserId).IsRequired();
        builder.Property(c => c.UpdatedDate).IsRequired();

        builder.Property(x => x.Quantity).IsRequired();
        builder.Property(x => x.HizmetId).IsRequired();
        builder.Property(x => x.EmployeeId).IsRequired();
        builder.Property(x => x.IsEmriId).IsRequired();
        builder.Property(x => x.Price).IsRequired();

        #region İŞ EMRİ DETAYINA AİT İLİŞKİLER
        builder.HasOne(bl => bl.IsEmri)
            .WithMany(bl => bl.IsEmriDetails)
            .HasForeignKey(bl => bl.IsEmriId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(bl => bl.Employee)
                .WithMany(bl => bl.IsEmriDetails)
                .HasForeignKey(bl => bl.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(bl => bl.Hizmet)
                .WithMany(bl => bl.IsEmriDetails)
                .HasForeignKey(bl => bl.HizmetId)
                .OnDelete(DeleteBehavior.Cascade);
        #endregion
        builder.ToTable("IsEmriDetails");

    }
}
