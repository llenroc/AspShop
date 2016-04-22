using RCS.AspShop.ServiceClients.Products.ProductsService;

namespace RCS.AspShop.Common
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