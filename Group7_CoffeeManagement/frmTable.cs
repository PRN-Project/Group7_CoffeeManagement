using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Group7_CoffeeManagement
{
    public partial class frmTable : Form
    {
        ITableRepository tableRepository = new TableRepository();
        BindingSource tableBindingSource = new BindingSource();

        private static readonly string TYPE_ALL = "Tất cả";

        public frmTable()
        {
            InitializeComponent();
            setUpComboBox();
            this.dgvTable.DataSource = tableBindingSource;
            RefreshTableList();
            setUpDataGridView();
        }

        private void setUpComboBox()
        {
            List<string> statusList = new List<string>();
            statusList.Add(TYPE_ALL);
            statusList.Add(TblTable.ACTIVE_STATUS);
            statusList.Add(TblTable.INACTIVE_STATUS);
            cbbStatus.DataSource = statusList;
            cbbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbStatus.SelectedIndex = 1;
        }


        public void RefreshTableList()
        {
            var chosenType = cbbStatus.SelectedItem as string;
            if (chosenType != TYPE_ALL)
            {
                LoadTableByStatus(TblTable.getStatusCodeByStringValue(chosenType));
            } else
            {
                tableBindingSource.DataSource = tableRepository.GetTableList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvTable.SelectedRows)
            {
                int rowid = Convert.ToInt32(item.Cells[0].Value);
                if (rowid>0)
                {
                    tableRepository.DeleteTableById(rowid);
                    dgvTable.Rows.RemoveAt(item.Index);
                }
                MessageBox.Show("Deleted!");
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewTable frmNewTable = new frmNewTable();
            frmNewTable.ShowDialog();
            RefreshTableList();
        }


        private void setUpDataGridView()
        {
            this.dgvTable.AllowUserToAddRows = false;
            
            this.dgvTable.Columns["Name"].HeaderText = "Tên bàn";
            this.dgvTable.Columns["DisplayedStatus"].HeaderText = "Trạng thái";
            
            this.dgvTable.Columns["Name"].HeaderCell.Style.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.GraphicsUnit.Point);
            this.dgvTable.Columns["DisplayedStatus"].HeaderCell.Style.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.GraphicsUnit.Point);

            this.dgvTable.Columns["TblOrders"].Visible = false;
            this.dgvTable.Columns["TableId"].Visible = false;
            this.dgvTable.Columns["Status"].Visible = false;

            this.dgvTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersVisible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var chosenTable = tableBindingSource.Current as TblTable;
            if (chosenTable != null)
            {
                frmNewTable frmUpdateTable = new frmNewTable(chosenTable);
                if (frmUpdateTable.ShowDialog() == DialogResult.OK)
                {
                    RefreshTableList();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewTable frmNewTable = new frmNewTable();
            if (frmNewTable.ShowDialog()  == DialogResult.OK)
            {
                RefreshTableList();
            }
        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTableList();
        }

        private void LoadTableByStatus (int status)
        {
            tableBindingSource.DataSource = tableRepository.LoadTableByStatus(status).ToList();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            tableBindingSource.DataSource = tableRepository.GetTableByName(txtSearchName.Text).ToList();
        }
    }
}
