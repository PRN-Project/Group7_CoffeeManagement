using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.list_item.custom_list_view
{
    public class OrderListViewManager
    {
        public delegate void OnItemFocusChange (OrderListItem item);

        public delegate void OnItemPriceChange (OrderListItem item);

        public delegate void OnItemModify (OrderListItem item);

        public event OnItemFocusChange onItemFocusChange;

        public event OnItemPriceChange onItemPriceChange;

        public event OnItemModify onItemRemoved;

        public event OnItemModify onItemAdded;

        private List<OrderListItem> itemList = new List<OrderListItem>();

        public OrderListItem Current { get; private set; }

        public List<OrderListItem> ItemList {
            get {
                return itemList;
            }
        }

        public void setData(List<TblFood> data)
        {
            foreach (TblFood drink in data)
            {
                addFood(drink);
            }
        }

        public void addFood(TblFood drink)
        {
            var newOrderItemView = new OrderListItem(drink.FoodId, drink.FoodName, drink.Price);
            newOrderItemView.setManager(this);
            itemList.Add(newOrderItemView);
            onItemAdded?.Invoke(newOrderItemView);
        }

        public void removeFood (TblFood drink)
        {
            foreach (OrderListItem orderItem in ItemList)
            {
                if (drink.FoodId == orderItem.drinkID)
                {
                    if (Current.drinkID == drink.FoodId)
                    {
                        Current = null;
                    }
                    ItemList.Remove(orderItem);
                    onItemRemoved?.Invoke(orderItem);
                }
            }
        }

        public void removeCurrent ()
        {
            if (Current != null) {
                ItemList.Remove(Current);
                onItemRemoved?.Invoke(Current);
                Current = null;
            }
        }

        public void changeFocus (OrderListItem focusedItem)
        {
            if (Current != null)
            {
                Current.clearFocus();
            }

            Current = focusedItem;
            onItemFocusChange?.Invoke(focusedItem);
        }

        public decimal getTotalPrice ()
        {
            if (ItemList.Count > 0)
            {
                decimal totalPrice = 0;
                foreach (OrderListItem orderItem in ItemList)
                {
                    totalPrice += orderItem.getTotalPrice();
                }

                return totalPrice;
                
            } else
            {
                return 0;
            }
        }

        public void sendPriceChangeEvent (OrderListItem item)
        {
            onItemPriceChange?.Invoke(item);
        }
    }
}
