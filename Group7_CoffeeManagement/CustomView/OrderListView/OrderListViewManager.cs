using Group7_CoffeeManagement.CustomView.Abstraction;
using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Group7_CoffeeManagement.CustomView.OrderListView
{
    public class OrderListViewManager : IListView<TblOrderDetail, OrderListItem>
    {
        public event OrderListItem.OnPriceChange onTotalPriceChange;

        public OrderListViewManager(FlowLayoutPanel panel) : base(panel)
        {
        }

        public void sendTotalPriceChangeEvent(OrderListItem item)
        {
            onTotalPriceChange?.Invoke(item);
        }

        protected override OrderListItem mapDataToItemView(TblOrderDetail data)
        {
            var itemView = new OrderListItem(data);
            itemView.Width = panel.Width - 8;
            return itemView;
        }

        public override void addItem(TblOrderDetail data)
        {
            var duplicateItem = GetItemViewByData(data);
            if (duplicateItem == null)
            {
                base.addItem(data);
            }
            else
            {
                duplicateItem.plustOneFoodEntity();
            }
        }


        private OrderListItem GetItemViewByData(TblOrderDetail data)
        {
            foreach (OrderListItem item in ItemList)
            {
                if (item.data.HasSameFood(data))
                {
                    return item;
                }
            }

            return null;
        }

        public decimal getTotalPrice()
        {
            if (ItemList.Count > 0)
            {
                decimal totalPrice = 0;
                foreach (OrderListItem orderItem in ItemList)
                {
                    totalPrice += orderItem.getTotalPrice();
                }

                return totalPrice;
            }
            else
            {
                return 0;
            }
        }

        public void CheckOut()
        {
            setData(new List<TblOrderDetail>());
        }
    }
}
