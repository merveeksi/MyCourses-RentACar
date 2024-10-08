using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Persistence.Contexts;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.Context;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("RentACar"))); // Veritabanı bağlantı dizesinin doğru olduğundan emin olun.
       
        services.AddScoped<IBrandRepository, BrandRepository>();
        // services.AddScoped<IModelRepository, ModelRepository>();
        //
        // services.AddScoped<IEmailAuthenticatorRepository, EmailAuthenticatorRepository>();
        // services.AddScoped<IOperationClaimRepository, OperationClaimRepository>();
        // services.AddScoped<IOtpAuthenticatorRepository, OtpAuthenticatorRepository>();
        // services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
        // services.AddScoped<IUserRepository, UserRepository>();
        // services.AddScoped<IUserOperationClaimRepository, UserOperationClaimRepository>();

        return services;
    }
}