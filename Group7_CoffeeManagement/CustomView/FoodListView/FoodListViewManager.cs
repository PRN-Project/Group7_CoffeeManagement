using Group7_CoffeeManagement.CustomView.Abstraction;
using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group7_CoffeeManagement.CustomView.FoodListView
{
    class FoodListViewManager : IListView<TblFood, FoodListItem>
    {
        public event ItemActionEvent onFoodButtonAddClickListener;

        public FoodListViewManager(FlowLayoutPanel _panel) : base(_panel)
        {
        }

        public override void setData(List<TblFood> dataList)
        {
            base.setData(dataList);
        }


        protected override FoodListItem mapDataToItemView(TblFood data)
        {
            FoodListItem itemView = new FoodListItem(data);
            itemView.Width = panel.Width - 10;
            itemView.setOnBtnAddClick(onBtnClick);
            return itemView;
        }

        private void onBtnClick(object sender, EventArgs e)
        {
            onFoodButtonAddClickListener?.Invoke((sender as Button).Parent as FoodListItem);
        }
    }
}
