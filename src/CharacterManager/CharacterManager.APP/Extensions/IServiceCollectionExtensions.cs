using CharacterManager.Domain.SQL.DataContext;
using CharacterManager.Infra.Common.Configurations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CharacterManager.APP.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DefaultContext>(options =>
                options
                .UseLazyLoadingProxies()
                .UseMySql(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }

        public static IServiceCollection AddOauthProvider(this IServiceCollection services, Auth0Configurations configurations)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.Authority = configurations.Authority;
                options.Audience = configurations.Audience;
            });

            return services;
        }
    }
}
