using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations;

public class SettingConfiguration : IEntityTypeConfiguration<Setting>
{
    public void Configure(EntityTypeBuilder<Setting> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.IsDeleted).IsRequired().HasDefaultValue(false);
        builder.Property(c => c.UpdateUserId).IsRequired();
        builder.Property(c => c.UpdatedDate).IsRequired();

        builder.Property(x=>x.Key).HasMaxLength(250).IsRequired();
        builder.Property(x=>x.Value).HasMaxLength(250).IsRequired();
        builder.ToTable("Settings");
    }
}
