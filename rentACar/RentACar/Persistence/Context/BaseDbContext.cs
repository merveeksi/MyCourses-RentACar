//using Core.Security.Entities;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Persistence.Context;

public class BaseDbContext:DbContext
{
    protected IConfiguration Configuration { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Fuel> Fuels { get; set; }
    public DbSet<Transmission> Transmissions { get; set; }
    public DbSet<Model> Models { get; set; }
    // public DbSet<OperationClaim> OperationClaims { get; set; }
    // public DbSet<OtpAuthenticator> OtpAuthenticators { get; set; }
    // public DbSet<RefreshToken> RefreshTokens { get; set; }
    // public DbSet<User> Users { get; set; }
    // public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    // public DbSet<EmailAuthenticator> EmailAuthenticators { get; set; }

    
    
    public BaseDbContext(DbContextOptions <BaseDbContext> options, IConfiguration configuration) : base(options)
    {
        Configuration = configuration;
        Database.EnsureCreated(); // Veritabanı yoksa oluşturulmasını sağlar.
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
// public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
//    {
//        Configuration = configuration;
//        Database.EnsureCreated();
//    }