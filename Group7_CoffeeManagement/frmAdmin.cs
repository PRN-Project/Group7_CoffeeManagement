using Group7_CoffeeManagement.form.frmFoodManagement;
using Group7_CoffeeManagement.form.frmFoodTypeManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group7_CoffeeManagement
{
    public partial class frmAdmin : Form
    {
        private static formFoodManagement formFoodManagement;

        private static formFoodType formFoodTypeManagement;

        private static frmTable formTableManagement;

        private List<Form> mdiChildren = new List<Form>();

        public frmAdmin()
        {
            InitializeComponent();
            SetUpMDI();
            SetUpFormList();
        }

        private void SetUpFormList ()
        {
            mdiChildren.Add(formFoodManagement);
            mdiChildren.Add(formFoodTypeManagement);
            mdiChildren.Add(formTableManagement);
        }

        private void ShowAForm (Form showedForm)
        {
            foreach (Form form in mdiChildren)
            {
                if (form != showedForm)
                {
                    form.Hide();
                }
            }

            showedForm.Show();
        }

        private void SetUpMDI ()
        {
            this.IsMdiContainer = true;
            this.AutoSize = true;

            // FOOD
            formFoodManagement = new formFoodManagement();
            formFoodManagement.FormBorderStyle = FormBorderStyle.None;
            formFoodManagement.Text = "Quản lí Menu";
            formFoodManagement.MdiParent = this;
            formFoodManagement.StartPosition = FormStartPosition.Manual;
            formFoodManagement.Left = 0;
            formFoodManagement.Top = 0;
            formFoodManagement.ControlBox = false;
            formFoodManagement.Show();

            // FOOD TYPE
            formFoodTypeManagement = new formFoodType();
            formFoodTypeManagement.FormBorderStyle = FormBorderStyle.None;
            formFoodTypeManagement.Text = "Quản lí Menu";
            formFoodTypeManagement.MdiParent = this;
            formFoodTypeManagement.StartPosition = FormStartPosition.Manual;
            formFoodTypeManagement.Left = 0;
            formFoodTypeManagement.Top = 0;
            formFoodTypeManagement.ControlBox = false;

            // TABLE
            formTableManagement = new frmTable();
            formTableManagement.FormBorderStyle = FormBorderStyle.None;
            formTableManagement.Text = "Quản lí Menu";
            formTableManagement.MdiParent = this;
            formTableManagement.StartPosition = FormStartPosition.Manual;
            formTableManagement.Left = 0;
            formTableManagement.Top = 0;
            formTableManagement.ControlBox = false;

        }

        private void manageMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAForm(formFoodManagement);
        }

        private void manageFoodTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAForm(formFoodTypeManagement);
        }

        private void manageTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAForm(formTableManagement);
        }
    }
}
