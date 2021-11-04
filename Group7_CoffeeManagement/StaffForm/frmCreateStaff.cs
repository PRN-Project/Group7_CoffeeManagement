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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                TblStaff staff = new TblStaff
                {
                    UserId = Int32.Parse(txtID.Text),
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                    Name = txtName.Text,
                    Role = Int32.Parse(txtRole.Text)
                };
                ValidationResult result = new CreateStaffValidator().Validate(staff);
                if (!result.IsValid)
                {
                    MessageBox.Show("Fail");
                }
                else staffRepository.AddStaff(staff);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error create new staff!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
