﻿using System.Collections.ObjectModel;

namespace RCS.AspShop.Common
{
    public abstract class Repository<T> : ProductsServiceConsumer
    {
        public Collection<T> List = new Collection<T>();

        public void Clear()
        {
            List.Clear();
        }
    }
}