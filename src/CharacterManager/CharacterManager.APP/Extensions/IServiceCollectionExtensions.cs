using CharacterManager.APP.Mappers.TestMappers;
using CharacterManager.Application.Interfaces;
using CharacterManager.Application.Services;
using CharacterManager.Domain.DataContracts;
using CharacterManager.Domain.Mongo.Repositories;
using CharacterManager.Infra.Commons.Configurations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CharacterManager.APP.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITestService, TestService>();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITestRepository, TestRepository>();
            return services;
        }

        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services.AddScoped<TestToTestDTOMapper>();
            services.AddScoped<TestDTOToTestMapper>();
            return services;
        }

        public static IServiceCollection AddConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            var mongoDBSettings = new MongoDBSettings();
            new ConfigureFromConfigurationOptions<MongoDBSettings>(configuration.GetSection("MongoDBSettings"))
                .Configure(mongoDBSettings);
            
            return services;
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoDBSettings>(configuration.GetSection("MongoDbSettings"));

            services.AddSingleton<MongoDBSettings>(serviceProvider =>
                serviceProvider.GetRequiredService<IOptions<MongoDBSettings>>().Value);


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
