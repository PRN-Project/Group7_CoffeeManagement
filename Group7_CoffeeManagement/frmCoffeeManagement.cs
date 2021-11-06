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
        public static TblStaff LogedInStaff;

        private ITableRepository tableRepository = new TableRepository();

        private IFoodRepository foodRepository = new FoodRepository();

        private IFoodTypeRepository foodTypeRepository = new FoodTypeRepository();

        private IOrderRepository orderRepository = new OrderRepository();

        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        private IRevenueRepository revenueRepository = new RevenueRepository();
        
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
            panelTables.Padding = new Padding(0);

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
                    row.Width = 352;
                    row.Height = 90;
                    row.Padding = new Padding(2);
                    row.Margin = new Padding(0);
                    panelTables.Controls.Add(row);
                }

                var tableItemView = createTableItemView(table);
                tableItemView.Margin = new Padding(2);
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
            button.Width = 112;
            button.Height = 85;
            button.Margin = new Padding(1);
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
                var currentTableInfor = getCoffeeTableInforByButton(currentChosenTable);
                if (currentTableInfor.Status == TableStatus.Empty)
                {
                    txtTotalPrice.Text = "_______";
                    btnUpdateOrder.Text = "Tạo bàn";
                    btnCheckOut.Hide();
                    btnCheckOutDisabled.Show();
                    txtEmpty.Show();
                }
                else
                {
                    btnUpdateOrder.Text = "Cập nhật";
                    btnCheckOut.Show();
                    btnCheckOutDisabled.Hide();
                    txtTotalPrice.Text = ((int) orderListViewManager.getTotalPrice()) + " vnđ";
                    txtEmpty.Hide();
                }
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
            var coffeeTableInformation = getCoffeeTableInforByButton(currentChosenTable);
            txtTableName.Text = coffeeTableInformation.Table.Name;
            orderListViewManager.setData(coffeeTableInformation.OrderDetailList);
            currentChosenTable.BackColor = Color.Bisque;
            if (coffeeTableInformation.Status  == TableStatus.Empty)
            {
                txtTotalPrice.Text = "_______";
                btnUpdateOrder.Text = "Tạo bàn";
                btnCheckOut.Hide();
                btnCheckOutDisabled.Show();
                txtEmpty.Show();
            }
            else
            {
                btnUpdateOrder.Text = "Cập nhật";
                btnCheckOut.Show();
                btnCheckOutDisabled.Hide();
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
            txtTotalPrice.Text = ((int)orderListViewManager.getTotalPrice()) + " vnđ";
        }

        #endregion

        #region Drink Process

        private void initFoodTypeCombobox ()
        {
            var typeList = foodTypeRepository.GetFoodTypeList();
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
                var decision = MessageBox.Show("Bạn muốn thanh toán \"" + currentChosenTable.Text + "\"?", "Xác nhận thanh toán", MessageBoxButtons.OKCancel);

                if (decision != DialogResult.OK)
                {
                    return;
                }

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
                revenueRepository.UpdateRevenue(order);

                frmCheckoutBill frmCheckoutBill = new frmCheckoutBill(order, orderDetailList, LogedInStaff, currentChosenTable.Text);
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
                if (orderListData.Count > 0)
                {
                    currentChosenCoffeeTableInfor.OrderDetailList = orderListData;
                    currentChosenTable.BackColor = TableListViewManager.NON_EMPTY_COLOR;
                    currentChosenTable.ForeColor = Color.White;
                    isModifyAnOrder = false;

                } else
                {
                    ShowNotification("Vui lòng chọn ít nhất một món ăn hoặc thức uống");
                }
            }
            else
            {
                ShowNotification("Vui lòng chọn bàn");
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
            this.btnCheckOutDisabled.Show();
            this.btnCheckOut.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnTransfer_Clicked(object sender, EventArgs e)
        {
            if (currentChosenTable != null)
            {
                if (getCoffeeTableInforByButton(currentChosenTable).Status == TableStatus.NonEmpty)
                {
                    Dictionary<Button, CoffeeTable> availableTableList = new Dictionary<Button, CoffeeTable>();

                    foreach (KeyValuePair<Button, CoffeeTable> tableInfor in tableDictionary)
                    {
                        if (tableInfor.Value.Status == TableStatus.Empty)
                        {
                            availableTableList.Add(tableInfor.Key, tableInfor.Value);
                        }
                    }

                    frmChooseTargetForm transferTableForm = new frmChooseTargetForm(this, availableTableList, currentChosenTable);
                    transferTableForm.ShowDialog();
                } else
                {
                    MessageBox.Show("Không thể chuyển bàn trống");
                }
            } else
            {
                MessageBox.Show("Vui lòng chọn bàn");
            }
        }

        public void transferTable (Button targetTable)
        {
            var currentCoffeeInfor = getCoffeeTableInforByButton(currentChosenTable);
            var targetCoffeeInfor = getCoffeeTableInforByButton(targetTable);
            targetCoffeeInfor.OrderDetailList.AddRange(currentCoffeeInfor.OrderDetailList);
            currentCoffeeInfor.OrderDetailList = null;
            tableListViewManager.transferTable(currentChosenTable, targetTable);

            currentChosenTable = targetTable;
            txtTableName.Text = targetTable.Text;
        }

        private CoffeeTable getCoffeeTableInforByButton (Button button)
        {
            return tableDictionary[button];
        }
    }
}
