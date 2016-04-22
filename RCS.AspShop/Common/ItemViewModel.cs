using Common.DomainClasses;

namespace RCS.AspShop.Common
{
    public abstract class ItemViewModel<T> : ViewModel where T : DomainClass
    {
        public int? ItemId
        {
            get { return Item != null ? Item.Id : null; }
            set { Refresh(value); }
        }

        public T Item { get; set; }

        public override void Refresh()
        {
            Refresh(ItemId);
        }

        public abstract void Refresh(object Id);
    }
}