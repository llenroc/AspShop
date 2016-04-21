using AspShop.ServiceClients.Products.ProductsService;

namespace AspShop.Common
{
    public class ProductsServiceConsumer
    {
        private ProductsServiceClient productsServiceClient;

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