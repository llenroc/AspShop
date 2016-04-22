using Common.DomainClasses;
using System;
using System.Collections.Generic;

namespace RCS.AspShop.Models
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartViewModel()
        {
            Items = new List<CartItem>();
        }

        public List<CartItem> Items { get; set; }

        public int ProductItemsCount { get; set; }

        public Decimal TotalValue { get; set; }

        public void Refresh()
        {
        }
    }
}