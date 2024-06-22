using Application.Abstractions;
using Infrastructure.Db;
using Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DepencyInjection
    {
        public static IServiceCollection AddInfrastructureDepencies(this IServiceCollection services) 
        {
            services.AddScoped<IAppDbContext, AppDbContext>();
            services.AddScoped<IHashService, HashService>();
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
