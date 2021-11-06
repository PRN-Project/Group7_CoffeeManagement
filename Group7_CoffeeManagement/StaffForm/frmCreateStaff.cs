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
        public frmCreateStaff()
        {
            InitializeComponent();
        }
         

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TblStaff staff = new TblStaff
                {
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                    Name = txtName.Text,
                    Role = 1
                };
                ValidationResult result = new CreateStaffValidator().Validate(staff);
                if (!result.IsValid)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ!!");
                }
                else
                {
                    staffRepository.AddStaff(staff);
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
