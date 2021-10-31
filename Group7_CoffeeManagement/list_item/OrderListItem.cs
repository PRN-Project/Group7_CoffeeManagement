using Group7_CoffeeManagement.list_item.custom_list_view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group7_CoffeeManagement.list_item
{
    public partial class OrderListItem : UserControl
    {
        private OrderListViewManager itemManger;

        public int drinkID { get; }

        public string drinkName { get; }

        public decimal drinkPrice { get; }
        
        public OrderListItem(int drinkID, string drinkName, decimal price)
        {
            InitializeComponent();
         
            txtDrinkPrice.Text = price + "";
            txtDrinkName.Text = drinkName;

            this.drinkID = drinkID;
            this.drinkPrice = price;
            this.drinkName = drinkName;
            
            updateTotalPrice();
            Click += onFocus;
            txtDrinkName.Click += onFocus;
            txtDrinkPrice.Click += onFocus;
            txtTotal.Click += onFocus;
        }

        public void setManager (OrderListViewManager manager)
        {
            this.itemManger = manager;
        }

        private void nudCount_ValueChanged(object sender, EventArgs e)
        {
            this.itemManger.sendPriceChangeEvent(this);
            updateTotalPrice();
        }

        private void updateTotalPrice ()
        {
            txtTotal.Text = "" + Int16.Parse(txtDrinkPrice.Text) * nudCount.Value;
        }

        public void onFocus (object sender, EventArgs e)
        {
            BackColor = Color.Blue;
            itemManger.changeFocus(this);
        }

        public void clearFocus()
        {
            BackColor = Color.White;
        }

        public decimal getTotalPrice()
        {
            return drinkPrice * nudCount.Value;
        }
    }
}
