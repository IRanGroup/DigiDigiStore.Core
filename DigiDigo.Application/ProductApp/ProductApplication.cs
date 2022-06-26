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
            var ProductAll = _ProductRepository.All();
            var Resualt = new List<ProductViewModel>();
            foreach (var item in ProductAll)
            {
                Resualt.Add(new ProductViewModel()
                {
                    Id = item.ProductId,
                    Name = item.Title,
                    ImageName=item.ImageName,
                    Price=item.Item.Price
                });
            }
            return Resualt;
        }


    }
}
