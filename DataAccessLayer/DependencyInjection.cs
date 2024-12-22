using eCommerce.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.ProductsService.DataAccessLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            //TO DO: Add Business Logic Layer services into the IoC container
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySQL(configuration.GetConnectionString("MySQLConnection")!);
            });

            return services;
        }
    }
}

