﻿using System.Collections.ObjectModel;

namespace AspShop.Common
{
    public abstract class ItemsViewModel<T> : ViewModel
    {
        public ItemsViewModel()
        {
            Items = new ObservableCollection<T>();
        }

        // TODO Some sort of view would be more convenient to enable sorting in situ (filtering is no longer done so). But remember: that no longer applies when paging.
        public ObservableCollection<T> Items { get; set; }

        // Convenience property to signal changes.
        // Note that just binding on Items.Count does not work.
        public int ItemsCount { get { return Items != null ? Items.Count : 0; } }
    }
}