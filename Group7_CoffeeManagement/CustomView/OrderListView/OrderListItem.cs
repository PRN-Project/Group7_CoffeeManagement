using System;
using System.Drawing;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.CustomView.Abstraction;

namespace Group7_CoffeeManagement.CustomView.OrderListView
{
    public partial class OrderListItem : IItemView<TblOrderDetail>
    {
        private OrderListViewManager itemManger;

        public delegate void OnPriceChange (OrderListItem price);

        public event OnPriceChange onPriceChange;

        public OrderListItem(TblOrderDetail data)
        {
            InitializeComponent();
            this.data = data;
            bindData(data);
            updateTotalPrice();
            Click += onFocus;
            txtDrinkName.Click += onFocus;
            txtDrinkPrice.Click += onFocus;
            txtTotal.Click += onFocus;
        }

        public override void setManager (Object manager)
        {
            this.itemManger = manager as OrderListViewManager;
        }

        private void nudCount_ValueChanged(object sender, EventArgs e)
        {
            updateTotalPrice();
            onPriceChange?.Invoke(this);
            this.itemManger.sendTotalPriceChangeEvent(this);
        }

        internal void plustOneFoodEntity()
        {
            this.nudCount.Value++;
        }

        private void updateTotalPrice ()
        {
            double totalPrice = Double.Parse(txtDrinkPrice.Text);
            txtTotal.Text = "" + totalPrice * ( (int) nudCount.Value);
        }

        public override void onFocus (object sender, EventArgs e)
        {
            BackColor = Color.Blue;
            itemManger.changeFocus(this);
        }

        public override void clearFocus()
        {
            BackColor = Color.White;
        }

        public decimal getTotalPrice()
        {
            return data.Food.Price * nudCount.Value;
        }
         
        public override void bindData(TblOrderDetail data)
        {
            txtDrinkPrice.Text = data.Food.Price + "";
            txtDrinkName.Text = data.Food.FoodName;
        }

    }
}
