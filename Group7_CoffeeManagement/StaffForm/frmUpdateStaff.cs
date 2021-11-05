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
        public static BindingSource staffSource = frmStaffManagement.staffSource;
        public frmUpdateStaff()
        {
            InitializeComponent();
            txtID.DataBindings.Add("Text", staffSource, "UserId");
            txtUsername.DataBindings.Add("Text", staffSource, "Username");
            txtPassword.DataBindings.Add("Text", staffSource, "Password");
            txtName.DataBindings.Add("Text", staffSource, "Name");
            txtRole.DataBindings.Add("Text", staffSource, "Role");
            txtID.ReadOnly = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TblStaff staff = staffRepository.GetStaffByID(Int32.Parse(txtID.Text));
            staff.UserName = txtUsername.Text;
            staff.Password = txtPassword.Text;
            staff.Name = txtName.Text;
            staff.Role = Int32.Parse(txtRole.Text);
            ValidationResult result = new UpdateStaffValidator().Validate(staff);
            if (!result.IsValid)
            {
                MessageBox.Show("Fail");
            }
            else staffRepository.UpdateStaff(staff);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
