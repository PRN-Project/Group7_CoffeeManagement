using Group7_CoffeeManagement.CustomView;
using Group7_CoffeeManagement.CustomView.FoodListView;
using Group7_CoffeeManagement.CustomView.OrderListView;
using Group7_CoffeeManagement.Interface;
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
        public static TblStaff LogedInStaff = new TblStaff()
        {
            UserId = 1,
            Name = "Robert",
            UserName = "staff@store",
            Password = "123"
        };

        private ITableRepository tableRepository = new TableRepository();

        private IFoodRepository foodRepository = new FoodRepository();

        private FoodTypeRepository foodTypeRepository = new FoodTypeRepository();

        private IOrderRepository orderRepository = new OrderRepository();

        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        
        private OrderListViewManager orderListViewManager;

        private FoodListViewManager drinkListViewManager;

        private TableListViewManager tableListViewManager;

        private List<TblFood> menu;

        private Dictionary<Button, CoffeeTable> tableDictionary = new Dictionary<Button, CoffeeTable>();

        private Button currentChosenTable = null;

        private bool isModifyAnOrder = false;

        public frmCoffeeManagement()
        {
            InitializeComponent();
            initTablePanel();
            initOrderListView();
            initMenu();
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
                if (i > 3)
                {
                    i = 1;
                }

                if (i == 1)
                {
                    row = new FlowLayoutPanel();
                    row.Width = 340;
                    row.Height = 90;
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
            button.Width = 103;
            button.Height = 85;
            button.Text = tableInfor.Name;
            button.Name = tableInfor.TableId + "";
            button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.GraphicsUnit.Point);

            button.Click += OnTableButton_Clicked;
            return button;
        }

        private void OnTableButton_Clicked(object sender, EventArgs e)
        {
            if (currentChosenTable == sender)
            {
                return;
            }

            if (isModifyAnOrder == true)
            {
                MessageBoxButtons saveButton = MessageBoxButtons.YesNoCancel;
                var decision = MessageBox.Show("Bạn có muốn lưu bàn hiện tại?", "Chú ý", saveButton);
                if (decision == DialogResult.Yes)
                {
                    updateCurrentTable();
                    isModifyAnOrder = false;
                } else if (decision == DialogResult.Cancel)
                {
                    tableListViewManager.disableFocusOnce();
                    return;
                } else
                {
                    isModifyAnOrder = false;
                }
            }

            currentChosenTable = sender as Button;
            var coffeeTableInformation = tableDictionary[sender as Button];
            txtTableName.Text = coffeeTableInformation.Table.Name;
            orderListViewManager.setData(coffeeTableInformation.OrderDetailList);
            currentChosenTable.BackColor = Color.Bisque;
            if (coffeeTableInformation.Status  == TableStatus.Empty)
            {
                txtTotalPrice.Text = "_______";
                txtEmpty.Show();
            } else
            {
                txtTotalPrice.Text = ((int) orderListViewManager.getTotalPrice()) + " vnđ";
                txtEmpty.Hide();
            }
        }

        #endregion

        #region Order Process

        private void initOrderListView()
        {
            orderListViewManager = new OrderListViewManager(panelOrder);
            panelOrder.FlowDirection = FlowDirection.TopDown;
            orderListViewManager.onTotalPriceChange += onTotalPriceChange;
            orderListViewManager.onItemRemoved += onDrinkRemoved;
            orderListViewManager.onItemAdded += onDrinkAdded;
        }

        private void onDrinkRemoved(OrderListItem item)
        {
            onTotalPriceChange(item);
        }

        private void onDrinkAdded(OrderListItem item)
        {
            onTotalPriceChange(item);
        }

        private void onTotalPriceChange(OrderListItem item)
        {
            txtTotalPrice.Text = ((int) orderListViewManager.getTotalPrice()) + " vnđ";
        }

        #endregion

        #region Drink Process

        private void initFoodTypeCombobox ()
        {
            var typeList = foodTypeRepository.getCustomType();
            cbbDrinkType.DataSource = typeList;
        }

        private void initMenu()
        {
            menu = foodRepository.GetFoodList().ToList();
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
            if (currentChosenTable == null)
            {
                ShowNotification("Vui lòng chọn bàn");
                return;
            }

            var food = item.data;
            orderListViewManager.addItem(new TblOrderDetail()
            {
                Food = food,
                FoodId = food.FoodId,
                Quantity = 1
            });

            txtEmpty.Hide();
            isModifyAnOrder = true;
        }

        #endregion

        private void btnRemoveDrinkOut_Click(object sender, EventArgs e)
        {
            isModifyAnOrder = true;
            orderListViewManager.removeCurrent();
        }

        #region Checkout
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            checkOut();
        }

        private void checkOut()
        {
            try
            {
                TblOrder order = new TblOrder();
                order.DateTime = DateTime.Now;
                CoffeeTable currentCoffeeTable = tableDictionary[currentChosenTable];
                var orderDetailList = currentCoffeeTable.OrderDetailList;

                order.TableId = currentCoffeeTable.Table.TableId;
                order.TotalPrice = orderListViewManager.getTotalPrice();
                order.UserId = LogedInStaff.UserId;

                orderRepository.Add(order);
                orderDetailRepository.CheckOut(order, currentCoffeeTable.OrderDetailList);
                tableListViewManager.CheckOut(currentChosenTable);
                orderListViewManager.CheckOut();

                frmCheckoutBill frmCheckoutBill = new frmCheckoutBill(order, orderDetailList, LogedInStaff);
                frmCheckoutBill.ShowDialog();
            }
            catch (Exception ex)
            {
                ShowNotification("Checkout failed. Error message: " + ex.Message);
            }
        }

        #endregion


        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            updateCurrentTable();
        } 

        private void updateCurrentTable ()
        {
            if (currentChosenTable != null)
            {
                var currentChosenCoffeeTableInfor = tableDictionary[currentChosenTable];
                var orderListData = orderListViewManager.getItemDataList();
                currentChosenCoffeeTableInfor.OrderDetailList = orderListData;
                currentChosenTable.BackColor = TableListViewManager.NON_EMPTY_COLOR;
                isModifyAnOrder = false;
            }
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

        private void edtFoodName_TextChanged(object sender, EventArgs e)
        {
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
    
        private void ShowNotification (string content)
        {
            MessageBox.Show(content);
        }

        private void frmCoffeeManagement_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
