using DigiDigo.Domain.ProductAgg;
using Microsoft.EntityFrameworkCore;
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
            return _Context.Products.Include(i => i.Item).ToList();
        }

    }
}
