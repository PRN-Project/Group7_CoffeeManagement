using Group7_CoffeeManagement.CustomView;
using Group7_CoffeeManagement.CustomView.FoodListView;
using Group7_CoffeeManagement.CustomView.OrderListView;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.Repository;
using Group7_CoffeeManagement.ViewModel;
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

        private TableRepository tableRepository = new TableRepository();

        private FoodRepository foodRepository = new FoodRepository();

        private FoodTypeRepository foodTypeRepository = new FoodTypeRepository();

        private OrderListViewManager orderListViewManager;

        private FoodListViewManager drinkListViewManager;

        private TableListViewManager tableListViewManager;

        private List<TblFood> menu;

        private Dictionary<Button, CoffeeTable> tableDictionary = new Dictionary<Button, CoffeeTable>();

        private Button currentChosenTable = null;


        public frmCoffeeManagement()
        {
            InitializeComponent();
            initTablePanel();
            initOrderListView();
            loadMenu();
            initFoodTypeCombobox();
        }

        #region Table Process

        private void initTablePanel ()
        {
            IEnumerable<TblTable> tableList = tableRepository.GetTableList();
            tableListViewManager = new TableListViewManager();

            var i = 1;
            FlowLayoutPanel row = new FlowLayoutPanel(); 
            foreach (TblTable table in tableList)
            {
                if (i > 4)
                {
                    i = 1;
                }

                if (i == 1)
                {
                    row = new FlowLayoutPanel();
                    row.Width = 340;
                    row.Height = 70;
                    panelTables.Controls.Add(row);

                }

                var tableItemView = createTableItemView(table);
                row.Controls.Add(tableItemView);
                tableDictionary[tableItemView] = new CoffeeTable(table);
                tableListViewManager.AddItem(tableItemView);
                i++;
            }

            tableListViewManager.setTableDictionary(tableDictionary);
        }

        private Button createTableItemView (TblTable tableInfor)
        {
            Button button = new Button();
            button.Width = 78;
            button.Height = 65;
            button.Text = tableInfor.Name;
            button.Name = tableInfor.TableId + "";

            button.Click += OnTableButton_Clicked;
            return button;
        }

        private void OnTableButton_Clicked(object sender, EventArgs e)
        {
            currentChosenTable = sender as Button;
            var coffeeTableInformation = tableDictionary[sender as Button];
            txtTableName.Text = coffeeTableInformation.Table.Name;
            orderListViewManager.setData(coffeeTableInformation.OrderDetailList);
            currentChosenTable.BackColor = Color.Bisque;
        }

        #endregion

        #region Order Process

        private void initOrderListView()
        {
            orderListViewManager = new OrderListViewManager(panelOrder);
            panelOrder.FlowDirection = FlowDirection.TopDown;
            orderListViewManager.onTotalPriceChange += onTotalPriceChange;
            orderListViewManager.onItemRemoved += onDrinkRemoved;
        }

        private void onDrinkRemoved(OrderListItem item)
        {
            onTotalPriceChange(item);
            panelOrder.Controls.Remove(item);
        }

        private void onTotalPriceChange(OrderListItem item)
        {
            txtTotalPrice.Text = orderListViewManager.getTotalPrice() + "";
        }

        #endregion

        #region Drink Process

        private void initFoodTypeCombobox ()
        {
            var typeList = foodTypeRepository.getCustomType();
            cbbDrinkType.DataSource = typeList;
        }

        private void loadMenu()
        {
            menu = (List<TblFood>)foodRepository.GetFoodList();
            panelMenu.FlowDirection = FlowDirection.TopDown;
            panelMenu.AutoScroll = true;
            panelMenu.WrapContents = false;

            drinkListViewManager = new FoodListViewManager(panelMenu);
            drinkListViewManager.setData(menu);
            drinkListViewManager.onFoodButtonAddClickListener += onFoodButtonAddClick;

            foreach (FoodListItem item in drinkListViewManager.ItemList)
            {
                panelMenu.Controls.Add(item);
            }
        }

        private void onFoodButtonAddClick(FoodListItem item)
        {
            var food = item.data;
            orderListViewManager.addItem(new TblOrderDetail()
            {
                Food = food,
                FoodId = food.FoodId,
                Quantity = 1
            });
        }

        #endregion

        private void btnRemoveDrinkOut_Click(object sender, EventArgs e)
        {
            orderListViewManager.removeCurrent();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            var currentChosenCoffeeTableInfor = tableDictionary[currentChosenTable];
            var orderListData = orderListViewManager.getItemDataList();
            currentChosenCoffeeTableInfor.OrderDetailList = orderListData;
            currentChosenTable.BackColor = TableListViewManager.NON_EMPTY_COLOR;
        } 

        private void cbbDrinkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chosenType = cbbDrinkType.SelectedItem as TblFoodType;
            filterMenuByType(chosenType);
        }

        private void filterMenuByType(TblFoodType chosenType)
        {
            var filtedList = menu.Where(food => food.TypeId == chosenType.TypeId).ToList() ;
            drinkListViewManager.setData(filtedList);
        }

        private void EdtFoodName_TextChanged(object sender, EventArgs e) {
            var keyword = edtFoodName.Text;
            var chosenType = cbbDrinkType.SelectedItem as TblFoodType;
            var sameTypeList = menu.Where(food => food.TypeId == chosenType.TypeId).ToList();
            if (keyword.Length == 0)
            {
                this.drinkListViewManager.setData(sameTypeList);
            } 
            else 
            {
                var filtedList = sameTypeList
                                        .Where(food => 
                                                     food.FoodName.Contains(keyword))
                                        .ToList();
                if (filtedList.Count < sameTypeList.Count)
                this.drinkListViewManager.setData(filtedList);
            }
        }
    }
}
