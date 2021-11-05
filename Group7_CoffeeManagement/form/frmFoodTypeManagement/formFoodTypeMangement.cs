using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group7_CoffeeManagement.form.frmFoodTypeManagement
{
    public partial class formFoodMangement : Form 
    {
        private IFoodTypeRepository foodTypeRepo = new FoodTypeRepository();
        private CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        private BindingSource bindingSource;
        public formFoodMangement()
        {
            InitializeComponent();
            //dtgvData.Columns["TblFoods"].Visible = false;
            getComboboxValue();
        }

        #region methods
        public void LoadFoodTypeList()
        {
            try
            {
                var foods = foodTypeRepo.GetFoodTypeList();
                bindingSource = new BindingSource();
                bindingSource.DataSource = foods;
                dtgvData.DataSource = null;
                dtgvData.DataSource = bindingSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error get food type list");
            }
        }

        public void AddFoodType()
        {
            formAddFoodType frm = new formAddFoodType();
            frm.Show();
        }

        public void LoadFoodTypeById(int id)
        {
            var foodType = foodTypeRepo.GetFoodTypeByID(id);
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = foodType;
                dtgvData.DataSource = null;
                dtgvData.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load Food Type By ID");
            }
        }

        public void LoadFoodTypeListByName(string name)
        {
            var foodType = foodTypeRepo.GetFoodTypeListByName(name);
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = foodType;
                dtgvData.DataSource = null;
                dtgvData.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load Food Type By Name");
            }
        }

        public void LoadFoodTypeListByType(int id)
        {
            try
            {
             
                var foodTypeList = foodTypeRepo.GetFoodTypeListByType(id);
                bindingSource = new BindingSource();
                bindingSource.DataSource = foodTypeList;
                dtgvData.DataSource = null;
                dtgvData.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load Product By Type");
            }
        }

        public void getComboboxValue()
        {
            cmbName.DataSource = foodTypeRepo.GetAll();
            cmbName.DisplayMember = "Description";
            cmbName.ValueMember = "TypeId";
        }


        #endregion

        #region events
        private void formFoodTypeMangement_Load(object sender, EventArgs e)
        {
            try
            {
                var foodTypes = foodTypeRepo.GetFoodTypeList();
                bindingSource = new BindingSource();
                bindingSource.DataSource = foodTypes;
                dtgvData.DataSource = null;
                dtgvData.DataSource = bindingSource;
                //AddBiding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Load Food Type List");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFoodType();
            LoadFoodTypeList();
        }

        private void dtgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Are you sure to delete this food?", "Notification",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (txtId.Text.Equals(""))
                {
                    MessageBox.Show("SELECT ID FOOD THAT YOU WANT TO DELETE");
                }
                else
                {
                    foodTypeRepo.RemoveFoodType(Int32.Parse(txtId.Text));

                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFoodTypeList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("SELECT ID FOOD THAT YOU WANT TO UPDATE");
            }
            else
            {
                formUpdateFoodType frm = new formUpdateFoodType(Int32.Parse(txtId.Text));
                frm.Show();
            }
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            try
            {
                int foodTypeId = Int32.Parse(txtId.Text);
                LoadFoodTypeById(foodTypeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Search Food Type By ID:");
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            int typeId = int.Parse(cmbName.SelectedValue.ToString());
            if (cmbName.SelectedItem.ToString() != null)
            {
                LoadFoodTypeListByType(typeId);
            }
            else MessageBox.Show("You must choose Type!");
        }


        #endregion

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
