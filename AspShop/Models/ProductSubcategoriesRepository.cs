using AspShop.Common;
using Common.DomainClasses;
using System.Collections.ObjectModel;

namespace AspShop.Models
{
    // TODO Make asynchronous.
    public class ProductSubcategoriesRepository : Repository<ProductSubcategory>
    {
        public Collection<ProductSubcategory> ReadList(bool addEmptyElement = true)
        {
            Clear();

            var subcategories = ProductsServiceClient.GetProductSubcategories();

            if (addEmptyElement)
            {
                var subcategory = new ProductSubcategory();
                List.Add(subcategory);
            }

            foreach (var subcategory in subcategories)
            {
                List.Add(subcategory);
            }

            return List;
        }
    }
}