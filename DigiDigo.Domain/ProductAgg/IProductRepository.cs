using System.Collections.Generic;

namespace DigiDigo.Domain.ProductAgg
{
    public interface IProductRepository
    {
        IList<Product> All();
    }
}
