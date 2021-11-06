using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group7_CoffeeManagement.CustomView.Abstraction
{
    public abstract class IItemView<Data> : UserControl
    {
        public Data data
        {
            get;
            set;
        }

        public abstract void onFocus(object sender, EventArgs e);

        public abstract void clearFocus();

        public abstract void bindData(Data data);

        public abstract void setManager(object manager);
    }

    public abstract class IListView<ItemType, ItemView> where ItemView : IItemView<ItemType>
                                                                               where ItemType : class
    {

        protected FlowLayoutPanel panel;

        public delegate void ItemActionEvent(ItemView item);

        public event ItemActionEvent onItemRemoved;

        public event ItemActionEvent onItemAdded;

        public event ItemActionEvent onItemFocusChange;

        private List<ItemView> itemViewList = new List<ItemView>();

        public ItemView CurrentItemView { get; private set; }

        public ItemType CurrentData
        {
            get
            {
                if (CurrentItemView != null)
                {
                    return CurrentItemView.data;

                }
                else
                {
                    return null;
                }
            }
        }

        public IListView(FlowLayoutPanel panel)
        {
            this.panel = panel;
        }

        protected abstract ItemView mapDataToItemView(ItemType data);

        public List<ItemView> ItemList
        {
            get
            {
                return itemViewList;
            }
        }

        virtual public void setData(List<ItemType> dataList)
        {
            panel.Controls.Clear();
            ItemList.Clear();
            foreach (ItemType data in dataList)
            {
                addItem(data);
            }
        }

        virtual public void addItem(ItemType data)
        {
            var itemView = mapDataToItemView(data);
            itemViewList.Add(itemView);
            itemView.setManager(this);
            panel.Controls.Add(itemView);
            onItemAdded?.Invoke(itemView);
            itemView.bindData(data);
        }

        virtual public void removeItem(ItemType item)
        {
            foreach (ItemView itemView in itemViewList)
            {
                if (itemView.data.Equals(item))
                {
                    removeItem(itemView);
                    break;
                }
            }
        }

        virtual public void removeItem(ItemView itemView)
        {
            if (CurrentItemView == itemView)
            {
                CurrentItemView = null;
            }

            itemViewList.Remove(itemView);
            panel.Controls.Remove(itemView);
            onItemRemoved?.Invoke(itemView);
        }

        public virtual void removeCurrent()
        {
            if (CurrentItemView != null)
            {
                removeItem(CurrentItemView);
            }
        }

        public void changeFocus (ItemView focusedItem)
        {
            if (focusedItem == CurrentItemView)
            {
                return;
            }

            if (CurrentItemView != null)
            {
                CurrentItemView.clearFocus();
            }

            CurrentItemView = focusedItem;
            onItemFocusChange?.Invoke(focusedItem);
        }

        public virtual List<ItemType> getItemDataList()
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
