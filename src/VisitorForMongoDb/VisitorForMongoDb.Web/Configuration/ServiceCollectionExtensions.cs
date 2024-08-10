using MongoDB.Driver;
using VisitorForMongoDb.Interfaces.Repositories;
using VisitorForMongoDb.Web.MongoDB;

namespace VisitorForMongoDb.Web.Configuration
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            var mongoDBSettings = configuration.GetSection("MongoDbSettings").Get<MongoDbSettings>();

            services.AddSingleton<IMongoClient>(it => new MongoClient(mongoDBSettings.ConnectionString));
            services.AddSingleton(it => it.GetRequiredService<IMongoClient>().GetDatabase(mongoDBSettings.DatabaseName));

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IFormRepository, IFormRepository>();

            return services;
        }
    }
}
