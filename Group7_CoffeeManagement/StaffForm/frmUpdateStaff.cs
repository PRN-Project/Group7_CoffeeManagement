using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Repository;
using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using Group7_CoffeeManagement.Validators;

namespace Group7_CoffeeManagement.StaffForm
{
    public partial class frmUpdateStaff : Form
    {
        IStaffRepository staffRepository = new StaffRepository();

        public const string ADMIN = "Quản trị viên";

        public const string MEMBER = "Nhân viên";


        private TblStaff staff;

        public frmUpdateStaff(TblStaff staffSource)
        {
            this.staff = staffSource;
            InitializeComponent();
            txtID.Text  = staffSource.UserId + "";
            txtUsername.Text = staffSource.UserName;
            txtPassword.Text = staffSource.Password;
            txtName.Text = staffSource.Name;
            txtID.ReadOnly = true;
            setUpComboBox();
            this.cbbRole.SelectedIndex = staff.Role;
        }

        private void setUpComboBox()
        {
            var option = new List<string>();
            option.Add(ADMIN);
            option.Add(MEMBER);
            this.cbbRole.DataSource = option;
            this.cbbRole.SelectedIndex = 1;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            staff.UserName = txtUsername.Text;
            staff.Password = txtPassword.Text;
            staff.Name = txtName.Text;
            staff.Role = cbbRole.SelectedIndex;
            ValidationResult result = new UpdateStaffValidator().Validate(staff);
            if (result.IsValid == false)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
            else
            {
                staffRepository.UpdateStaff(staff);
                MessageBox.Show("Cập nhật nhân viên thành công");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
