using DigiDigo.Application.contract.ProductAppCon;
using DigiDigo.Application.ProductApp;
using DigiDigo.Domain.ProductAgg;
using DigiDigo.Infrastrure.EFCore;
using DigiDigo.Infrastrure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DigiDigo.Infrastrure.Core.DependenceIOC
{
    public class Bootstrapper
    {
        public static void Config(IServiceCollection service,string connection)
        {
            service.AddTransient<IProductApplication, ProductApplication>();
            service.AddTransient<IProductRepository, ProductRepository>();
            service.AddDbContext<DigiDigoContext>(options =>
            {
                options.UseSqlServer(connection);
            });

        }

    }
}
