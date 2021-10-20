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

namespace Group7_CoffeeManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public frmCoffeeManagement frmManagement = new frmCoffeeManagement();
        public CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        public LoginRepository repo = new LoginRepository();

        private void btnExit_Click(object sender, EventArgs e) => this.Close();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TblStaff loginUser = repo.checkLogin(txtUsername.Text, txtPassword.Text);
            if (loginUser != null)
            {
                frmManagement.ShowDialog();
            }
        }
    }
}
