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

namespace Group7_CoffeeManagement.Revenue
{
    public partial class frmRevenue : Form
    {
        IRevenueRepository revenueRepository = new RevenueRepository();
        BindingSource source;
        public frmRevenue()
        {
            InitializeComponent();
            LoadOrderList();
        }

        public void LoadOrderList()
        {
            var orders = revenueRepository.GetListOrderOfDay(DateTime.Today);
            try
            {
                source = new BindingSource();
                source.DataSource = orders;
                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            decimal revenue = revenueRepository.GetRevenueOfDay(23);
            MessageBox.Show(revenue.ToString());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
