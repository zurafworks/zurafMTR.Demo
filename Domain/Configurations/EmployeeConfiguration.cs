using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.IsDeleted).IsRequired().HasDefaultValue(false);
        builder.Property(c => c.UpdateUserId).IsRequired();
        builder.Property(c => c.UpdatedDate).IsRequired();

        builder.Property(x=>x.FirstName).HasMaxLength(250).IsRequired();
        builder.Property(x=>x.LastName).HasMaxLength(250).IsRequired();
        builder.Property(x=>x.PhoneNumber).HasMaxLength(20).IsRequired();
        builder.Property(x=>x.BirthDate).IsRequired();
        builder.Property(x=>x.HireDate).IsRequired();

        #region ÇALIŞAN İŞ EMRİ İLİŞKİSİ
        builder.HasMany(bl => bl.IsEmriDetails)
            .WithOne(bl => bl.Employee)
            .HasForeignKey(bl => bl.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);
        #endregion
        builder.ToTable("Employees");
    }
}
