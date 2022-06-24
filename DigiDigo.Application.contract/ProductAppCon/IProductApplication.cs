using System.Collections.Generic;

namespace DigiDigo.Application.contract.ProductAppCon
{
    public interface IProductApplication
    {
        IEnumerable<ProductViewModel> SelectAll();

    }
}
