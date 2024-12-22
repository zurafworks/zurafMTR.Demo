using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations;

public class HizmetConfiguration : IEntityTypeConfiguration<Hizmet>
{
    public void Configure(EntityTypeBuilder<Hizmet> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.IsDeleted).IsRequired().HasDefaultValue(false);
        builder.Property(c => c.UpdateUserId).IsRequired();
        builder.Property(c => c.UpdatedDate).IsRequired();

        builder.Property(x=>x.Name).HasMaxLength(250).IsRequired();
        builder.Property(x=>x.Description).HasMaxLength(1000).IsRequired();
        builder.Property(x=>x.BasePrice).IsRequired();

        #region İŞ EMRİ HİZMET İLİŞKİSİ
        builder.HasMany(bl => bl.IsEmriDetails)
            .WithOne(bl => bl.Hizmet)
            .HasForeignKey(bl => bl.HizmetId)
            .OnDelete(DeleteBehavior.Cascade);
        #endregion
        builder.ToTable("Hizmets");
    }
}
