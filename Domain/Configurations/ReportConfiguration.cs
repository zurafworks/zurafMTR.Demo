using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations;

public class ReportConfiguration : IEntityTypeConfiguration<Report>
{
    public void Configure(EntityTypeBuilder<Report> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.IsDeleted).IsRequired().HasDefaultValue(false);
        builder.Property(c => c.UpdateUserId).IsRequired();
        builder.Property(c => c.UpdatedDate).IsRequired();

        builder.Property(x=>x.IsEmriId).IsRequired();
        builder.Property(x=>x.Path).HasMaxLength(150).IsRequired();
        builder.Property(x=>x.CreatedDate).IsRequired();
        #region ARAÇ BAKIM İLİŞKİSİ
        builder.HasOne(bl => bl.IsEmri)
            .WithMany(bl => bl.Reports)
            .HasForeignKey(bl => bl.IsEmriId)
            .OnDelete(DeleteBehavior.Cascade);
        #endregion
        builder.ToTable("Reports");
    }
}
