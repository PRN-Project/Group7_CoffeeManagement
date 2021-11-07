using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.Repository;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Group7_CoffeeManagement
{
    public partial class frmNewTable : Form
    {
        ITableRepository TableRepository = new TableRepository();

        private bool isUpdateMode = false;

        private TblTable beingUpdatedTable;

        public frmNewTable()
        {
            InitializeComponent();
            setUpComboBox();
        }

        public frmNewTable (TblTable table) : this()
        {
            this.beingUpdatedTable = table;
            isUpdateMode = true;
            setUpUpdateData(table);
        }

        private void setUpUpdateData (TblTable table) {
            this.txtName.Text = table.Name;
            cbbStatus.SelectedIndex = table.Status;

            btnAdd.Text = "Lưu";
            label3.Text = "Cập nhật bàn";
        }


        private void setUpComboBox()
        {
            List<string> statusList = new List<string>();
            statusList.Add(TblTable.ACTIVE_STATUS);
            statusList.Add(TblTable.INACTIVE_STATUS);
            cbbStatus.DataSource = statusList;
            cbbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private string check()
        {
            if (txtName.Text.Length == 0)
            {
                return "Tên bàn không được để trống";
            }
            else
            {
                return null;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        => Close();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string errorCheck = check();
                if (errorCheck != null)
                {
                    MessageBox.Show(errorCheck);
                }
                else
                {
                   
                    if (isUpdateMode)
                    {
                        beingUpdatedTable.Name = txtName.Text;
                        beingUpdatedTable.Status = TblTable.getStatusCodeByStringValue(cbbStatus.SelectedItem as string);

                        TableRepository.UpdateTable(beingUpdatedTable);
                        MessageBox.Show("Cập nhật bàn thành công");
                    }
                    else // this is Adding Mode
                    {
                        TblTable table = new TblTable();
                        table.Name = txtName.Text;
                        table.Status = TblTable.getStatusCodeByStringValue(cbbStatus.SelectedItem as string);
                        TableRepository.AddTable(table);
                        MessageBox.Show("Thêm bàn thành công");
                    }

                    DialogResult = DialogResult.OK;
                    Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi. Error message: " + ex.Message);
            }
        }
    }
}
