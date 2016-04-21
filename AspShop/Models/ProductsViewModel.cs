using AspShop.Common;
using Common.DomainClasses;
using System;
using System.Linq;

namespace AspShop.Models
{
    public class ProductsViewModel : FilterItemsViewModel<ProductsOverviewObject, ProductCategory, ProductSubcategory>
    {
        public ProductsViewModel()
        {
            // HACK
            MasterFilterValue = new ProductCategory() { Id = 1, Name = "Bikes" };
            DetailFilterValue = new ProductSubcategory() { Id = 1, ProductCategoryId = 1, Name = "Mountain Bikes" };
            TextFilterValue = "sil";
        }

        private bool filterInitialized;

        public override void Refresh()
        {
            Items.Clear();

            if (!filterInitialized)
            {
                InitializeFilters();
                ReadFiltered();
            }
            else
            {
                ReadFiltered();
            }
        }

        ProductCategoriesRepository productCategoriesRepository = new ProductCategoriesRepository();
        ProductSubcategoriesRepository productSubcategoriesRepository = new ProductSubcategoriesRepository();

        protected override void InitializeFilters()
        {
            var productCategories = productCategoriesRepository.ReadList();

            foreach (var item in productCategories)
            {
                MasterFilterItems.Add(item);
            }

            var productSubcategories = productSubcategoriesRepository.ReadList();

            foreach (var item in productSubcategories)
            {
                detailFilterItemsSource.Add(item);
                // HACK
                DetailFilterItems.Add(item);
            }

            int masterDefaultId = 1;
            MasterFilterValue = MasterFilterItems.FirstOrDefault(category => category.Id == masterDefaultId);

            // TODO Note that MasterFilterValue also determines DetailFilterItems.
            int detailDefaultId = 1;
            DetailFilterValue = DetailFilterItems.FirstOrDefault(subcategory => subcategory.Id == detailDefaultId);

            TextFilterValue = default(string);

            filterInitialized = true;
        }

        ProductsRepository productsRepository = new ProductsRepository();

        private void ReadFiltered()
        {
            var result = productsRepository.ReadList(MasterFilterValue, DetailFilterValue, TextFilterValue);

            foreach (var item in result)
            {
                Items.Add(item);
            }
        }

        protected override Func<ProductSubcategory, bool> DetailFilterItemsSelector(bool preserveEmptyElement = true)
        {
            return subcategory =>
                MasterFilterValue != null &&
                !MasterFilterValue.IsEmpty() &&
                (preserveEmptyElement && subcategory.IsEmpty() || subcategory.ProductCategoryId == MasterFilterValue.Id);
        }
    }
}