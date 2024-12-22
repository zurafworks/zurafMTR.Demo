using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.IsDeleted).IsRequired().HasDefaultValue(false);
        builder.Property(c => c.UpdateUserId).IsRequired();
        builder.Property(c => c.UpdatedDate).IsRequired();

        builder.Property(x => x.FirstName).HasMaxLength(250).IsRequired();
        builder.Property(x => x.LastName).HasMaxLength(250).IsRequired();
        builder.Property(x => x.Address).HasMaxLength(500);
        builder.Property(x => x.Phone).HasMaxLength(20).IsRequired();

        #region MÜŞTERİ ARAÇ İLİŞKİSİ
        builder.HasMany(bl => bl.Vehicles)
            .WithOne(bl => bl.Customer)
            .HasForeignKey(bl => bl.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);
        #endregion
        builder.ToTable("Customers");
    }
}
