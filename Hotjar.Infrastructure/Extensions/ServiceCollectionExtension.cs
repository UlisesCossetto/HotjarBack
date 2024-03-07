//using Hotjar.Infrastructure.Datos;
using Hotjar.Core.Interfaces.Managers;
using Hotjar.Core.Interfaces.Repositories;
using Hotjar.Core.Managers;
using Hotjar.Infrastructure.Data;
using Hotjar.Infrastructure.Interfaces;
using Hotjar.Infrastructure.Repositories;
using Hotjar.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDbContextsMariaDB(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("HotjarMariaDB");
            services.AddDbContext<HotjarDbContext>(options =>
                 options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
                     mysqlOptions => mysqlOptions.CommandTimeout(180)) // Ajusta el tiempo de espera según sea necesario
             );


            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IBookServices, BookServices>();

            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<IBookManager, BookManager>();

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }

            public static IServiceCollection AddAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                var jwtAppSettings = configuration.GetSection("JwtIssuerOptions");

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = jwtAppSettings["Issuer"],
                    ValidateAudience = true,
                    ValidAudience = jwtAppSettings["Audience"],
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(s: jwtAppSettings["SecretKey"])),
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };

                options.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException) && !context.Request.Path.Equals("/Revalidar", StringComparison.OrdinalIgnoreCase))
                        {
                            context.Response.Headers.Add("Token-Expired", "true");
                        }
                        return System.Threading.Tasks.Task.CompletedTask;
                    }
                };
            });
            services.AddAuthorization();
            return services;
        }
    }
}
