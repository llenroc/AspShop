using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace RCS.AspShop.Common
{
    public abstract class FilterItemsViewModel<T, V, W> : ItemsViewModel<T>
    {
        public FilterItemsViewModel()
        {
            MasterFilterItems = new ObservableCollection<V>();
            DetailFilterItems = new ObservableCollection<W>();
        }

        protected abstract void InitializeFilters();

        public ObservableCollection<V> MasterFilterItems { get; set; }

        public V MasterFilterValue { get; set; }

        private void SetDetailFilterItems(bool addEmptyElement = true)
        {
            var detailFilterItemsSelection = detailFilterItemsSource.Where(DetailFilterItemsSelector());

            DetailFilterItems.Clear();

            // Note that the query is executed on the foreach.
            foreach (var item in detailFilterItemsSelection)
            {
                DetailFilterItems.Add(item);
            }
        }

        protected abstract Func<W, bool> DetailFilterItemsSelector(bool addEmptyElement = true);

        protected Collection<W> detailFilterItemsSource = new Collection<W>();
        public ObservableCollection<W> DetailFilterItems { get; set; }

        public W DetailFilterValue { get; set; }

        public string TextFilterValue { get; set; }
    }
}