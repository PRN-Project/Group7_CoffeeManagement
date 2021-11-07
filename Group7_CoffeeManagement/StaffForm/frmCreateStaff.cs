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
using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.Repository;
using Group7_CoffeeManagement.Validators;

namespace Group7_CoffeeManagement.StaffForm
{
    public partial class frmCreateStaff : Form
    {
        IStaffRepository staffRepository = new StaffRepository();

        public const string ADMIN = "Quản trị viên";

        public const string MEMBER = "Nhân viên";

        public frmCreateStaff()
        {
            InitializeComponent();
            setUpComboBox();
        }

        private void setUpComboBox()
        {
            var option = new List<string>();
            option.Add(ADMIN);
            option.Add(MEMBER);
            this.cbbRole.DataSource = option;
            this.cbbRole.SelectedIndex = 1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var duplicate = staffRepository.FindMemberByUserName(txtUsername.Text);
                if (duplicate != null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác");
                    return;
                }

                TblStaff staff = new TblStaff
                {
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                    Name = txtName.Text,
                    Role = cbbRole.SelectedIndex
                };
                ValidationResult result = new CreateStaffValidator().Validate(staff);
                if (!result.IsValid)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ!!");
                }
                else
                {
                    staffRepository.AddStaff(staff);
                    MessageBox.Show("Tạo tài khoản thành công");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi xảy ra khi tạo nhân viên");
            }
        }
    }
}
