using Core.Domain.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // Primary key
        builder.HasKey(u => u.Id);

        builder.HasIndex(u => u.NormalizedUserName).HasDatabaseName("UserNameIndex").IsUnique();
        builder.HasIndex(u => u.NormalizedEmail).HasDatabaseName("EmailIndex");

        builder.ToTable("AspNetUsers");

        builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

        builder.Property(u => u.UserName).HasMaxLength(50);
        builder.Property(u => u.NormalizedUserName).HasMaxLength(50);
        builder.Property(u => u.Email).HasMaxLength(100);
        builder.Property(u => u.NormalizedEmail).HasMaxLength(100);


        builder.HasMany<UserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

        builder.HasMany<UserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

        builder.HasMany<UserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

        builder.HasMany<UserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

        var adminUser = new User
        {
            Id = 1,
            UserName = "ahmetciftci",
            FirstName = "Ahmet",
            LastName = "Çiftçi",
            NormalizedUserName = "AHMETCIFTCI",
            Email = "aciftci976@gmail.com",
            NormalizedEmail = "ACIFTCI976@GMAIL.COM",
            PhoneNumber = "+905555555555",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
        };
        adminUser.PasswordHash = CreatePasswordHash(adminUser, "2002!a.C87200395");
        var editorUser = new User
        {
            Id = 2,
            UserName = "mehmetgoksu",
            FirstName = "Mehmet",
            LastName = "Göksu ",
            NormalizedUserName = "MEHMETGOKSU",
            Email = "mehmetgoksu4386@gmail.com",
            NormalizedEmail = "MEHMETGOKSU4386@GMAIL.COM",
            PhoneNumber = "+905555555555",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
        };
        editorUser.PasswordHash = CreatePasswordHash(editorUser, "2002!m.G88201396");

        builder.HasData(adminUser, editorUser);
    }
    private string CreatePasswordHash(User user, string password)
    {
        var passwordHasher = new PasswordHasher<User>();
        return passwordHasher.HashPassword(user, password);
    }
}
