using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.list_item
{
    public interface IItemView <Data>
    {
        public Data data {
            get;
            set;
        }

        abstract void onFocus();

        abstract void clearFocus();
    }

    abstract class IListView <ItemType, ItemView> where ItemView : class, IItemView<ItemType>
                                                                               where ItemType : class
    {

        public delegate void ItemActionEvent(ItemView item);

        public event ItemActionEvent onItemRemoved;

        public event ItemActionEvent onItemAdded;

        public event ItemActionEvent onItemFocusChange;

        private List<ItemView> itemViewList = new List<ItemView>();

        public ItemView Current { get; private set; }

        public List<ItemView> ItemList
        {
            get
            {
                return itemViewList;
            }
        }

        virtual public void setData(List<ItemType> data)
        {

        }

        virtual public void addItem(ItemType item)
        {

        }

        virtual public void removeItem(ItemType item)
        {

        }

        virtual public void removeItem(ItemView item)
        {

        }

        public virtual void removeCurrent()
        {
            if (Current != null)
            {
                ItemList.Remove(Current);
                onItemRemoved?.Invoke(Current);
                Current = null;
            }
        }

        public void changeFocus(ItemView focusedItem)
        {
            if (Current != null)
            {
                Current.clearFocus();
            }

            Current = focusedItem;
            onItemFocusChange?.Invoke(focusedItem);
        }

        public virtual List<ItemType> getItemDataList ()
        {
            var result = new List<ItemType>();

            foreach (ItemView itemView in itemViewList)
            {
                result.Add(itemView.data);
            }

            return result;
        }
    }
}
