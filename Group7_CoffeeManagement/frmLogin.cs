using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.Repository;
using System.Windows.Forms;
using Group7_CoffeeManagement.Validators;
using Group7_CoffeeManagement.Repository;
using Group7_CoffeeManagement.Interface;
using FluentValidation.Results;
using Group7_CoffeeManagement.form.frmFoodManagement;

namespace Group7_CoffeeManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public static frmCoffeeManagement frmManagement = new frmCoffeeManagement();
        public static formFoodManagement frmFood = new formFoodManagement();
        public static CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        public static AuthRepository repo = new AuthRepository();
        public static BindingSource roleSource = new BindingSource();

        private void btnExit_Click(object sender, EventArgs e) => this.Close();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TblStaff logedInUser = repo.checkLogin(txtUsername.Text, txtPassword.Text);
            if (logedInUser != null)
            {
                if (logedInUser.Role == 0)
                {
                    frmCoffeeManagement.LogedInStaff = logedInUser;
                    roleSource.DataSource = "US";
                    this.Hide();
                    var logOut = new frmCoffeeManagement().ShowDialog();
                    if (logOut == DialogResult.OK)
                    {
                        this.Show();
                    } else
                    {
                        Application.Exit();
                    }
                } else
                {
                    roleSource.DataSource = "AD";
                    this.Hide();
                    var logOut = new frmAdmin().ShowDialog();
                    if (logOut == DialogResult.OK)
                    {
                        this.Show();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            } else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }
    }
}
