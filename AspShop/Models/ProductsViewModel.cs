using AspShop.ServiceClients.Products.ProductsService;
using Common.DomainClasses;
using System.Collections.Generic;

namespace AspShop.Models
{
    public class ProductsViewModel
    {
        public ProductsViewModel()
        {
            Items = new List<ProductsOverviewObject>();
        }

        public List<ProductsOverviewObject> Items { get; set; }

        public void ReadFiltered()
        {
            // HACK
            var masterFilterValue = new ProductCategory() { Id = 1 };
            var detailFilterValue = new ProductSubcategory() { Id = 1, ProductCategoryId = 1 };
            var textFilterValue = "sil";
            var result = ReadList(masterFilterValue, detailFilterValue, textFilterValue);

            foreach (var item in result)
            {
                Items.Add(item);
            }
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

        public IList<ProductsOverviewObject> ReadList(ProductCategory category, ProductSubcategory subcategory, string namePart)
        {
            var productOverview = ProductsServiceClient.GetProductsOverviewBy(
                    category != null ? category.Id : null,
                    subcategory != null ? subcategory.Id : null,
                    namePart);

            return productOverview;
        }
    }
}