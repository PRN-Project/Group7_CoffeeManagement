using BusinessModel;
using CoffeeManagementLibrary.DataAccess.drink;
using DataAccess.table;
using Group7_CoffeeManagement.list_item;
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

namespace Group7_CoffeeManagement
{
    public partial class frmCoffeeManagement : Form
    {

        private ITableRepository tableRepository;

        private IDrinkRepository drinkRepository;

        private OrderListViewManager listViewManager = new OrderListViewManager();
        

        public frmCoffeeManagement()
        {
            InitializeComponent();
            tableRepository = new MockTableRepository();
            loadTableList();
            loadOrderList();
            loadMenu();
        }

        #region Table Process

        private void loadTableList ()
        {
            IEnumerable<TableObject> tableList = tableRepository.GetTableList();

            var i = 1;
            FlowLayoutPanel row = new FlowLayoutPanel();
            row.Width = 340;
            row.Height = 70;
            foreach (TableObject table in tableList)
            {
                if (i > 4)
                {
                    panelTables.Controls.Add(row);
                    row = new FlowLayoutPanel();
                    row.Width = 340;
                    row.Height = 70;
                    i = 1;
                }
                else
                {
                    Button button = new Button();
                    button.Width = 78;
                    button.Height = 65;
                    button.Text = table.Name;
                   
                    row.Controls.Add(button);
                    i++;
                }
            }
        }

        #endregion

        #region Order Process

        private void loadOrderList()
        {
            panelOrder.FlowDirection = FlowDirection.TopDown;
            for (int i = 0; i < 12; i++)
            {
                listViewManager.addFood(new Models.TblFood()
                {
                    FoodId = i,
                    FoodName = "Drink " + i,
                    Price = i * 100,
                });
            }

            foreach (OrderListItem orderItem in listViewManager.ItemList)
            {
                panelOrder.Controls.Add(orderItem);
            }

            listViewManager.onItemPriceChange += onTotalPriceChange;
            listViewManager.onItemRemoved += onDrinkRemoved;
        }

        private void onDrinkRemoved(OrderListItem item)
        {
            onTotalPriceChange(item);
            panelOrder.Controls.Remove(item);
        }

        private void onTotalPriceChange(OrderListItem item)
        {
            txtTotalPrice.Text = listViewManager.getTotalPrice() + "";
        }

        private void onFocusAnItem(OrderListItem focusedItem)
        {

        }

        #endregion


        #region Drink Process

        private void loadMenu()
        {
            var menuList = drinkRepository.LoadAllMenu();
        }

        #endregion  

        private void btnRemoveDrinkOut_Click(object sender, EventArgs e)
        {
            listViewManager.removeCurrent();
        }
    }
}
