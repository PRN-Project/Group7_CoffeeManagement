using Group7_CoffeeManagement.Models;
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
        public frmCheckoutBill(TblOrder order, List<TblOrderDetail> orderDetailList, TblStaff staff)
        {
            InitializeComponent();
            bindData(order, orderDetailList, staff);
        }

        private void bindData (TblOrder order, List<TblOrderDetail> orderDetailList, TblStaff staff)
        {
            dgvOrderDetails.DataSource = convertToBillRow(orderDetailList);
            txtTotalPrice.Text = order.TotalPrice + " vnđ";
        }

        private List<BillRow> convertToBillRow (List<TblOrderDetail> orderDetails) {
            var result = new List<BillRow>();
            orderDetails.ForEach(detail =>
               result.Add(new BillRow()
               {
                   FoodName = detail.Food.FoodName,
                   Price = detail.Food.Price,
                   Quantity = detail.Quantity,
                   TotalPrice = detail.Quantity * detail.Food.Price
               })); 

            return result;
         }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
