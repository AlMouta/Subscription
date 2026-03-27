using Microsoft.EntityFrameworkCore;
using Subscription.Infra.Data.Contexts;

namespace Subscription.Api.Extensions
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Método para adicionar as dependências da infraestrutura como repositórios, contextos, etc.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfraStructure(this IServiceCollection services, IConfiguration configuration)
        {

            //Configurando o DbContext do Entity Framework Core para usar SQL Server
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")
             ));

            return services;
        }
    }
}
