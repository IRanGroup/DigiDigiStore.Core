using DigiDigo.Application.contract.ProductAppCon;
using DigiDigo.Domain.ProductAgg;
using System.Collections.Generic;
using System.Linq;

namespace DigiDigo.Infrastrure.EFCore.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DigiDigoContext _Context;

        public ProductRepository(DigiDigoContext context)
        {
            _Context = context;
        }

        public IList<Product> All()
        {
            return _Context.Products.ToList();
        }

    }
}
