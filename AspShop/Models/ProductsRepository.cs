using AspShop.Common;
using AspShop.ServiceClients.Products.ProductsService;
using Common.DomainClasses;
using System.Collections.Generic;

namespace AspShop.Models
{
    // TODO Make asynchronous.
    public class ProductsRepository : Repository<ProductsOverviewObject>
    {
        public IList<ProductsOverviewObject> ReadList(ProductCategory category, ProductSubcategory subcategory, string namePart)
        {
            var productOverview = ProductsServiceClient.GetProductsOverviewBy(
                    category != null ? category.Id : null,
                    subcategory != null ? subcategory.Id : null,
                    namePart);

            return productOverview;
        }

        public Product ReadDetails(int productID)
        {
            var product = ProductsServiceClient.GetProductDetails(productID);

            return product;
        }
    }
}