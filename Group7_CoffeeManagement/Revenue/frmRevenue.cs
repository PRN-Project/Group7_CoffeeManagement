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

        private const string BY_DATE = "Theo ngày";

        private const string BY_MONTH = "Theo tháng";

        private const string BY_YEAR = "Theo năm";

        private const string BY_DATE_RANGE = "Theo khoảng thời gian";

        private Dictionary<string, Panel> panelDictionary = new Dictionary<string, Panel>();

        public frmRevenue()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            this.dgvOrderList.DataSource = bindingSource;
            LoadOrderList();
            SetUpComboBox();
            SetUpPanels();
            setUpDataGridView();
        }

        private void SetUpComboBox()
        {
            List<string> filterList = new List<string>();
            filterList.Add(BY_DATE);
            filterList.Add(BY_MONTH);
            filterList.Add(BY_YEAR);
            filterList.Add(BY_DATE_RANGE);
            cbbFilterType.DataSource = filterList;
        }

        private void SetUpPanels()
        {
            this.panelDate.Show();
            this.panelByMonth.Hide();
            this.panelYear.Hide();
            this.panelDateRange.Hide();

            panelDictionary.Add(BY_DATE, panelDate);
            panelDictionary.Add(BY_MONTH, panelByMonth);
            panelDictionary.Add(BY_YEAR, panelYear);
            panelDictionary.Add(BY_DATE_RANGE, panelDateRange);
        }

        public void LoadOrderList()
        {
            dtpDate_ofDate.Value = DateTime.Today;
            var orders = revenueRepository.GetListOrderOfDay(DateTime.Today);
            try
            {
                bindingSource.DataSource = orders; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xảy ra lỗi khi tải doanh thu");
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var chosenFilterType = cbbFilterType.SelectedItem as String;
            var showedPanel = panelDictionary[chosenFilterType];
            showAFilterPanel(showedPanel);
        }

        private void setUpDataGridView()
        {
            this.dgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersVisible = false;

            this.dgvOrderList.Columns["Table"].Visible = false;
            this.dgvOrderList.Columns["TblOrderDetails"].Visible = false;
            this.dgvOrderList.Columns["User"].Visible = false;
        }


        private void showAFilterPanel(Panel showedPanel)
        {
            foreach (Panel panel in panelDictionary.Values)
            {
                if (panel != showedPanel)
                {
                    panel.Hide();
                }
            }

            showedPanel.Show();
        }

        private void btnOutputRevenue_Click(object sender, EventArgs e)
        {
            string chosenType = cbbFilterType.SelectedValue as string;
            switch (chosenType)
            {
                case BY_DATE:
                    {
                        showByDate();
                        break;
                    }
                case BY_MONTH:
                    {
                        showByMonth();
                        break;
                    }
                case BY_YEAR:
                    {
                        showByYear();
                        break;
                    }
                case BY_DATE_RANGE:
                    {
                        showByDateRange();
                        break;
                    }
            }
        }

        private void showByDate ()
        {
            DateTime date = dtpDate_ofDate.Value;
            var revenueObject = revenueRepository.GetRevenueOfDay(date);
            var orderList = revenueRepository.GetListOrderOfDay(date);
            outputRevenue(revenueObject.Revenue, orderList); 
        }

        private void showByMonth()
        {
            DateTime date = dtpDate_ofDate.Value;
            var revenueObject = revenueRepository.GetRevenueOfDay(date);
            var orderList = revenueRepository.GetListOrderOfDay(date);
            outputRevenue(revenueObject.Revenue, orderList);
        }

        private void showByYear()
        {
            DateTime date = dtpDate_ofDate.Value;
            var revenueObject = revenueRepository.GetRevenueOfDay(date);
            var orderList = revenueRepository.GetListOrderOfDay(date);
            outputRevenue(revenueObject.Revenue, orderList);
        }

        private void showByDateRange()
        {
            DateTime date = dtpDate_ofDate.Value;
            var revenueObject = revenueRepository.GetRevenueOfDay(date);
            var orderList = revenueRepository.GetListOrderOfDay(date);
            outputRevenue(revenueObject.Revenue, orderList);
        }

        private void outputRevenue (decimal totalRevenue, IEnumerable<TblOrder> order)
        {
            txtTotal.Text = totalRevenue.ToDisplayText();
            bindingSource.DataSource = order;
        }
    }
}
