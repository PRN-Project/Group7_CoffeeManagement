using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group7_CoffeeManagement.Repository;
using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;

namespace Group7_CoffeeManagement.StaffForm
{
    public partial class frmStaffManagement : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private IStaffRepository staffRepository = new StaffRepository();
        
        public frmStaffManagement()
        {
            InitializeComponent();
            this.dgvStaff.DataSource = bindingSource;
            LoadStaffList();
            SetUpDataGridView();
        }

        private void SetUpDataGridView()
        {
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersVisible = false;

            dgvStaff.Columns["UserId"].HeaderText = "Mã số";
            dgvStaff.Columns["UserName"].HeaderText = "Tên đăng nhập";
            dgvStaff.Columns["Password"].HeaderText = "Mật khẩu";
            dgvStaff.Columns["Name"].HeaderText = "Tên";
            dgvStaff.Columns["DisplayedRole"].HeaderText = "Chức vụ";
            
            dgvStaff.Columns["UserId"].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 12F, GraphicsUnit.Point);
            dgvStaff.Columns["UserName"].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 12F, GraphicsUnit.Point);
            dgvStaff.Columns["Password"].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 12F, GraphicsUnit.Point);
            dgvStaff.Columns["Name"].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 12F, GraphicsUnit.Point);
            dgvStaff.Columns["DisplayedRole"].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 12F, GraphicsUnit.Point);

            dgvStaff.Columns["Role"].Visible = false;
            dgvStaff.Columns["TblOrders"].Visible = false;
        }

        public void LoadStaffList()
        {
            try
            {
                var staffs = staffRepository.GetStaffs();
                bindingSource.DataSource = staffs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xảy ra lỗi khi tải thông tin nhân viên");
            }
        }
         
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCreateStaff formAddStaff = new frmCreateStaff();
            if (formAddStaff.ShowDialog() == DialogResult.OK)
            {
                LoadStaffList();
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            var keyword = txtSearchName.Text;
            LoadStaffListByName(keyword);
        }

        private void LoadStaffListByName(string keyword)
        {
            bindingSource.DataSource = staffRepository.GetStaffByName(keyword);
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                var chosenStaff = bindingSource.Current as TblStaff;
                if (chosenStaff == null)
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật");
                    return;
                }
                frmUpdateStaff formUpdate = new frmUpdateStaff(chosenStaff);
                if (formUpdate.ShowDialog() == DialogResult.OK)
                {
                    LoadStaffList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xảy ra lỗi khi cập nhật");
            }
        }
    }
}
