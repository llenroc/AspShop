using AspShop.ServiceClients.Products.ProductsService;
using Common.DomainClasses;

namespace AspShop.Models
{
    public class ProductViewModel
    {
        public Product Item { get; set; }

        public void Refresh(object productId)
        {
            Item = ReadDetails((int)productId);
        }

        private Product ReadDetails(int productID)
        {
            var product = ProductsServiceClient.GetProductDetails(productID);

            return product;
        }

        private ProductsServiceClient productsServiceClient;

        // TODO Check this.
        protected ProductsServiceClient ProductsServiceClient
        {
            get
            {
                if (productsServiceClient == null)
                    productsServiceClient = new ProductsServiceClient();

                return productsServiceClient;
            }
        }
    }
}