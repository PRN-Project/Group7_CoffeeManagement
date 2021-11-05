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
        public static BindingSource staffSource = new BindingSource();
        BindingSource idSource = frmLogin.idSource;
        BindingSource source;
        IStaffRepository staffRepository = new StaffRepository();
        
        public frmStaffManagement()
        {
            InitializeComponent();
            LoadStaffList();
            this.txtId.Visible = false;
        }
        public void LoadStaffList()
        {
            var staffs = staffRepository.GetStaffs();
            try
            {
                source = new BindingSource();
                source.DataSource = staffs;
                dgvStaffList.DataSource = null;
                dgvStaffList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Staff List");
            }
        }

        private void dgvStaffList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStaffList.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateStaff formAddStaff = new frmCreateStaff();
            formAddStaff.ShowDialog();
            LoadStaffList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(idSource.DataSource.ToString()) != Int32.Parse(txtId.Text))
            {
                DialogResult dlt = MessageBox.Show("Are you sure delete ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlt == DialogResult.Yes)
                {
                    if (txtId.Text.Equals(""))
                    {
                        MessageBox.Show("Select staff you want to delete");
                    }
                    else
                    {
                        staffRepository.RemoveStaff(Int32.Parse(txtId.Text));
                    }
                }
            }
            else MessageBox.Show("You can not delete yourself");
            
            LoadStaffList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                staffSource.DataSource = staffRepository.GetStaffByID(Int32.Parse(txtId.Text));
                frmUpdateStaff formUpdate = new frmUpdateStaff();
                formUpdate.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Staff");
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchByName_Click(object sender, EventArgs e)
        {
            var staffsByName = staffRepository.GetStaffByName(txtName.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = staffsByName;
                dgvStaffList.DataSource = null;
                dgvStaffList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Staff List By Name");
            }
        }
    }
}
