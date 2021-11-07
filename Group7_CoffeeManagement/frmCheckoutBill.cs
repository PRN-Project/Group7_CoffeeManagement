using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.Repository;
using Group7_CoffeeManagement.Utils;
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
    public partial class frmCheckoutBill : Form
    {
        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public frmCheckoutBill(TblOrder order, List<TblOrderDetail> orderDetailList, TblStaff staff)
        {
            InitializeComponent();
            bindData(order, orderDetailList, staff);
            setUpDataGridView();
            this.Text = "Hóa đơn bán hàng";
            this.label1.Text = "Thanh toán thành công";
        }

        public frmCheckoutBill(TblOrder order)
        {
            var staff = order.User;
            var orderDetailList = orderDetailRepository.getOrderDetailByOrderId(order.OrderId).ToList();
            InitializeComponent();
            bindData(order, orderDetailList, staff);
            setUpDataGridView();
            this.Text = "Hóa đơn bán hàng";
        }

        private void setUpDataGridView()
        {
            this.dgvOrderDetails.Columns["FoodName"].HeaderText = "Tên";
            this.dgvOrderDetails.Columns["Price"].HeaderText = "Giá";
            this.dgvOrderDetails.Columns["Quantity"].HeaderText = "Số lượng";
            this.dgvOrderDetails.Columns["TotalPrice"].HeaderText = "Tổng";
        }

        private void bindData (TblOrder order, List<TblOrderDetail> orderDetailList, TblStaff staff)
        {
            dgvOrderDetails.DataSource = convertToBillRow(orderDetailList);
            txtTotalPrice.Text = order.TotalPrice.ToDisplayText();

            txtDate.Text = DateTime.Now.ToString();
            txtStaffName.Text = staff.Name;
        }

        private List<BillRow> convertToBillRow (List<TblOrderDetail> orderDetails) {
            var result = new List<BillRow>();
            orderDetails.ForEach(detail =>
               result.Add(new BillRow()
               {
                   FoodName = detail.Food.FoodName,
                   Price = detail.Food.Price.ToDisplayText(),
                   Quantity = detail.Quantity,
                   TotalPrice = (detail.Quantity * detail.Food.Price).ToDisplayText()
               })); ; 

            return result;
         }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrintBill_Clicked(object sender, EventArgs e)
        {
            MessageBox.Show("Cám ơn đã sử dụng sản phẩm. Tính năng này hiện chưa hỗ trợ");
        }
    }
}
