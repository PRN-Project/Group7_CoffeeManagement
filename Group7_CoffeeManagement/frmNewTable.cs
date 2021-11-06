using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.Repository;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Group7_CoffeeManagement
{
    public partial class frmNewTable : Form
    {
        ITableRepository TableRepository = new TableRepository();
        public frmNewTable()
        {
            InitializeComponent();

        }

        bool IsNumber(string age)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(age);
        }
        private string check()
        {
            string msg = "";
            string name = txtName.Text;

            if (name.Equals(""))
            {
                msg += "Please Enter Name!\n";
            }
            if (IsNumber(name))
            {
                msg += "Wrong Name!Try Again..\n";
            }
            int status;
            if (!string.IsNullOrWhiteSpace(txtStatus.Text) && int.TryParse(txtStatus.Text, out status))
            {
                if (status != 1 && status != 0)
                {
                    msg += "Status must be 1 or 0 value!\n";
                }
            }
            else
            {
                msg += "Please Enter Status!\n";
            }
            return msg;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = check();
            if (msg.Length!=0)
            {
                MessageBox.Show(msg);
            }
            else
            {
                var table = new TblTable
                {
                    Name = txtName.Text,
                    Status = int.Parse(txtStatus.Text)
                };
                TableRepository.AddTable(table);
                MessageBox.Show("Added!");
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        => Close();
    }
}
