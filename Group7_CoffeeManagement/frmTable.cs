using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.Repository;
using System;
using System.Text.RegularExpressions;
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
            loadTableToGdv();
        }

        public void loadTableToGdv()
        {
            var table = tableRepository.GetTableList();
            source = new BindingSource();
            source.DataSource = table;

            txtStatus.DataBindings.Clear();
            txtName.DataBindings.Clear();


            txtStatus.DataBindings.Add("Text", source, "Status");
            txtName.DataBindings.Add("Text", source, "Name");

            //dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
            dataGridView1.Columns["TblOrders"].Visible = false;

        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
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
                loadTableToGdv();
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
            frmNewTable frmNewTable = new frmNewTable();
            frmNewTable.ShowDialog();
            loadTableToGdv();
        }

        private void frmTable_Load(object sender, EventArgs e)
        {

        }

        bool IsNumber(string age)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(age);
        }
        private string check()
        {
            string msg = "";
            string name = txtName.Text;

            if (name.Equals(""))
            {
                msg += "Please Enter Name!\n";
            }
            if (IsNumber(name))
            {
                msg += "Wrong Name!Try Again..\n";
            }
            int status;
            if (!string.IsNullOrWhiteSpace(txtStatus.Text) && int.TryParse(txtStatus.Text, out status))
            {
                if (status != 1 && status != 0)
                {
                    msg += "Status must be 1 or 0 value!\n";
                }
            }
            else
            {
                msg += "Please Enter Status!\n";
            }
            return msg;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string msg = check();
            if (msg.Length != 0)
            {
                MessageBox.Show(msg);
            }
            else
            {
                var table = new TblTable
                {
                    Status = int.Parse(txtStatus.Text),
                    Name = txtName.Text
                };
                tableRepository.UpdateTable(table);
                MessageBox.Show("Updated!");
                loadTableToGdv();
            }
            
        }
    }
}
