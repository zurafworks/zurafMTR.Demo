using Core.Domain.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.HasKey(r => new { r.UserId, r.RoleId });

        builder.ToTable("AspNetUserRoles");

        builder.HasData(
            new UserRole
            {
                RoleId = 1,
                UserId = 1,

            },
            new UserRole
            {
                RoleId = 1,
                UserId = 2,
            });
    }
}
