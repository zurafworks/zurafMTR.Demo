using Core.Domain.Concrete;
using Core.Persistance.Configurations;
using Domain.Configurations;
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Contexts;

public class zurafMTRContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
{
    public DbSet<BakimLog> BakimLogs { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Hizmet> Hizmets { get; set; }
    public DbSet<IsEmri> IsEmris { get; set; }
    public DbSet<IsEmriDetail> IsEmriDetails { get; set; }
    public DbSet<Report> Reports { get; set; }
    public DbSet<Setting> Settings { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public zurafMTRContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new RoleClaimConfiguration());
        builder.ApplyConfiguration(new RoleConfiguraion());
        builder.ApplyConfiguration(new UserClaimConfiguration());
        builder.ApplyConfiguration(new UserLoginConfiguration());
        builder.ApplyConfiguration(new UserConfiguration());
        builder.ApplyConfiguration(new UserRoleConfiguration());
        builder.ApplyConfiguration(new UserTokenConfiguration());
        builder.ApplyConfiguration(new BakimLogConfiguration());
        builder.ApplyConfiguration(new CustomerConfiguration());
        builder.ApplyConfiguration(new EmployeeConfiguration());
        builder.ApplyConfiguration(new HizmetConfiguration());
        builder.ApplyConfiguration(new IsEmriConfiguration());
        builder.ApplyConfiguration(new IsEmriDetailConfiguration());
        builder.ApplyConfiguration(new ReportConfiguration());
        builder.ApplyConfiguration(new SettingConfiguration());
        builder.ApplyConfiguration(new VehicleConfiguration());
    }
}
