using RCS.AdventureWorks.Common.DomainClasses;
using RCS.AspShop.Common;
using System.Collections.ObjectModel;

namespace RCS.AspShop.Models
{
    // TODO Make asynchronous.
    public class ProductCategoriesRepository : Repository<ProductCategory>
    {
        public Collection<ProductCategory> ReadList(bool addEmptyElement = true)
        {
            Clear();

            var categories = ProductsServiceClient.GetProductCategories();

            if (addEmptyElement)
            {
                var category = new ProductCategory() { Name = string.Empty };
                List.Add(category);
            }

            foreach (var category in categories)
            {
                List.Add(category);
            }

            return List;
        }
    }
}