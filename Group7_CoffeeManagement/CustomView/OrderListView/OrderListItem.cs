using System;
using System.Drawing;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.CustomView.Abstraction;
using Group7_CoffeeManagement.Utils;

namespace Group7_CoffeeManagement.CustomView.OrderListView
{
    public partial class OrderListItem : IItemView<TblOrderDetail>
    {
        private OrderListViewManager itemManger;

        public delegate void OnPriceChange(OrderListItem price);

        public event OnPriceChange onPriceChange;

        public OrderListItem(TblOrderDetail data)
        {
            InitializeComponent();
            this.data = data;
            updateTotalPrice();
            Click += onFocus;
            txtDrinkName.Click += onFocus;
            txtDrinkPrice.Click += onFocus;
            txtTotal.Click += onFocus;
        }

        public override void setManager(Object manager)
        {
            this.itemManger = manager as OrderListViewManager;
        }

        private void nudCount_ValueChanged(object sender, EventArgs e)
        {
            updateTotalPrice();
            onPriceChange?.Invoke(this);
            this.itemManger.sendTotalPriceChangeEvent(this);
            this.data.Quantity = (int)nudCount.Value;
        }

        internal void plustOneFoodEntity()
        {
            this.nudCount.Value++;
        }

        private void updateTotalPrice()
        {
            decimal unitPrice = this.data.Food.Price;
            txtTotal.Text = (unitPrice * nudCount.Value).ToDisplayText();
        }

        private void setBackground (Color color, Color textColor)
        {
            BackColor = color;
            txtDrinkName.BackColor = color;
            txtDrinkPrice.BackColor = color;
            txtTotal.BackColor = color;
            txtFoodName.BackColor = color;

            txtDrinkName.ForeColor = textColor;
            txtDrinkPrice.ForeColor = textColor;
            txtTotal.ForeColor = textColor;
            txtFoodName.ForeColor = textColor;
        }

        public override void onFocus(object sender, EventArgs e)
        {
            setBackground(Color.CadetBlue, Color.White);
            itemManger.changeFocus(this);
        }

        public override void clearFocus()
        {
            setBackground(Color.White, Color.Black);
        }

        public decimal getTotalPrice()
        {
            return data.Food.Price * nudCount.Value;
        }

        public override void bindData(TblOrderDetail data)
        {
            txtDrinkPrice.Text = data.Food.Price.ToDisplayText();
            txtDrinkName.Text = data.Food.FoodName;
            nudCount.Value = data.Quantity;
            txtTotal.Text = (data.Food.Price * data.Quantity).ToDisplayText();
        }

    }
}


//using System;
//using System.Drawing;
//using Group7_CoffeeManagement.Models;
//using Group7_CoffeeManagement.CustomView.Abstraction;
//using System.Windows.Forms;

//namespace Group7_CoffeeManagement.CustomView.OrderListView
//{
//    public partial class OrderListItem : UserControl
//    {
//        public OrderListItem(TblOrderDetail data)
//        {
//            InitializeComponent();
//        }

//        private void nudCount_ValueChanged(object sender, EventArgs e)
//        {

//        }

//    }
//}
