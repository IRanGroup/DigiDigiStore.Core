using DigiDigo.Application.contract.ProductAppCon;
using DigiDigo.Domain.ProductAgg;
using System.Collections.Generic;

namespace DigiDigo.Application.ProductApp
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _ProductRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            _ProductRepository = productRepository;
        }

        public IEnumerable<ProductViewModel> SelectAll()
        {
            var ProductList = _ProductRepository.All();
            var Products = new List<ProductViewModel>();
            foreach (var item in ProductList)
            {
                Products.Add(new ProductViewModel()
                {
                    Id = item.ProductId,
                    Name = item.Title,
                    ImageName = item.ImageName,
                    Price = 2123
                });
            }
            return Products;
        }


    }
}
