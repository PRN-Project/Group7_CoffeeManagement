using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Repository;
using Group7_CoffeeManagement.Models;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group7_CoffeeManagement.Utils;

namespace Group7_CoffeeManagement.Revenue
{
    public partial class frmRevenue : Form
    {
        IRevenueRepository revenueRepository = new RevenueRepository();
        BindingSource bindingSource;

        public frmRevenue()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            this.dgvOrderList.DataSource = bindingSource;
            LoadOrderList();
            setUpDataGridView();
        }

        public void LoadOrderList()
        {
            try
            {
                dtpDate_ofDate.Value = DateTime.Today;
                var orders = revenueRepository.GetListOrderOfDay(DateTime.Today);
                if (orders == null)
                {
                    return;
                }
                var revenue = revenueRepository.GetRevenueOfDay(DateTime.Today);

                if (revenue == null)
                {
                    return;
                }

                var totalRevenue = revenue.Revenue;
                bindingSource.DataSource = orders;
                txtTotal.Text = totalRevenue.ToDisplayText() + " vnđ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xảy ra lỗi khi tải doanh thu");
            }
        }

        private void setUpDataGridView()
        {
            this.dgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersVisible = false;
            try
            {
                this.dgvOrderList.Columns["OrderId"].HeaderText = "Mã số";
                this.dgvOrderList.Columns["DisplayedTotalPrice"].HeaderText = "Tổng";
                this.dgvOrderList.Columns["DateTime"].HeaderText = "Ngày giờ";
                this.dgvOrderList.Columns["User"].HeaderText = "Nhân viên";
                this.dgvOrderList.Columns["Table"].HeaderText = "Bàn";

                this.dgvOrderList.Columns["OrderId"].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 12F, GraphicsUnit.Point);
                this.dgvOrderList.Columns["DisplayedTotalPrice"].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 12F, GraphicsUnit.Point);
                this.dgvOrderList.Columns["DateTime"].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 12F, GraphicsUnit.Point);
                this.dgvOrderList.Columns["User"].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 12F, GraphicsUnit.Point);
                this.dgvOrderList.Columns["Table"].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 12F, GraphicsUnit.Point);

                this.dgvOrderList.Columns["UserId"].Visible = false;
                this.dgvOrderList.Columns["TotalPrice"].Visible = false;
                this.dgvOrderList.Columns["TableId"].Visible = false;
                this.dgvOrderList.Columns["TblOrderDetails"].Visible = false;

            } catch (Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
            }
        }

        private void btnOutputRevenue_Click(object sender, EventArgs e)
        {
             showByDate();
        }

        private void showByDate ()
        {
            try
            {
                DateTime date = dtpDate_ofDate.Value;
                var revenueObject = revenueRepository.GetRevenueOfDay(date);
                var orderList = revenueRepository.GetListOrderOfDay(date);
                outputRevenue(revenueObject.Revenue, orderList);
            }
            catch  (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
         }

        private void outputRevenue (decimal totalRevenue, IEnumerable<TblOrder> order)
        {
            txtTotal.Text = totalRevenue.ToDisplayText() + " vnđ";
            bindingSource.DataSource = order;
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            var chosenOrder = bindingSource.Current as TblOrder;
            if (chosenOrder != null)
            {
                new frmCheckoutBill(chosenOrder).ShowDialog();
            } else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }
        }
    }
}
