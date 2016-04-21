using AspShop.Common;
using Common.DomainClasses;

namespace AspShop.Models
{
    public class ProductViewModel : ItemViewModel<Product>
    {
        private ProductsRepository productsRepository = new ProductsRepository();

        public override void Refresh(object productId)
        {
            Item = productsRepository.ReadDetails((int)productId);
        }
    }
}