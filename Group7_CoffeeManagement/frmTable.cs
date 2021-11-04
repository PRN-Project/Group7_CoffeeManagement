using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.Repository;
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
    public partial class frmTable : Form
    {
        ITableRepository tableRepository = new TableRepository();
        BindingSource source;
        public frmTable()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
        }

        private void loadTableToGdv()
        {
            var table = tableRepository.GetTableList();
            source = new BindingSource();
            source.DataSource = table;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;

            loadTableToGdv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int rowid = Convert.ToInt32(item.Cells[0].Value);
                if (rowid>0)
                {
                    tableRepository.DeleteTableById(rowid);
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
                MessageBox.Show("Deleted!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Enter Search Name");
            }
            else
            {
                TblTable table = tableRepository.GetTableByName(txtSearch.Text);
                source = new BindingSource();
                source.DataSource = table;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewTable frmNewTable = new frmNewTable()
            {
                Text = "Add New Table",
                TableRepository = tableRepository
            };
            if (frmNewTable.ShowDialog() == DialogResult.OK)
            {
                loadTableToGdv();
                source.Position = source.Count - 1;
            }
        }
    }
}
