﻿using Group7_CoffeeManagement.Interface;
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

namespace Group7_CoffeeManagement.form.frmFoodManagement
{
    public partial class formFoodManagement : Form
    {
        private IFoodRepository foodRepository = new FoodRepository();
        private IFoodTypeRepository foodTypeRepo = new FoodTypeRepository();
        private CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        private BindingSource bindingSource;

        public formFoodManagement()
        {
            InitializeComponent();
            getComboboxValue();
            cmbSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtId.Visible = false;
            txtSearchId.Visible = false;
            btnSearchId.Visible = false;
            //AddBiding();
        }


        #region methods

        public void getComboboxValue()
        {
            cmbSearchType.DataSource = foodTypeRepo.GetAll();
            cmbSearchType.DisplayMember = "Description";
            cmbSearchType.ValueMember = "TypeId";
        }
        public void LoadFoodList()
        {
            try
            {
                var foods = foodRepository.GetFoodList();
                bindingSource = new BindingSource();
                bindingSource.DataSource = foods;
                dtgvData.DataSource = null;
                dtgvData.DataSource = bindingSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error get food list");
            }
        }

        

        public void AddFood()
        {
            formAddFood frm = new formAddFood();
            frm.Show();
        }

        public void LoadFoodListById(int foodId)
        {
            var foods = foodRepository.GetFoodByID(foodId);
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = foods;
                dtgvData.DataSource = null;
                dtgvData.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load Food By ID");
            }
        }

        public void LoadFoodListByName(string name)
        {
            var foodList = foodRepository.GetFoodListByName(name);
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = foodList;
                dtgvData.DataSource = null;
                dtgvData.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load Food By Name");
            }
        }

        public void LoadFoodListByType(int typeId)
        {        
            try
            {
                var foodList = foodRepository.GetFoodListByType(typeId);
                bindingSource = new BindingSource();
                bindingSource.DataSource = foodList;
                dtgvData.DataSource = null;
                dtgvData.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load Product By Type");
            }
        }


        #endregion

        #region events
        private void frmFoods_Load(object sender, EventArgs e)
        {
            try
            {
                var foods = foodRepository.GetFoodList();
                bindingSource = new BindingSource();
                bindingSource.DataSource = foods;
                dtgvData.DataSource = null;
                dtgvData.DataSource = bindingSource;
                //AddBiding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Load Food List");
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFood();
            LoadFoodList();
           // AddBiding();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Are you sure to delete this food?", "Notification",
                                               MessageBoxButtons.YesNoCancel);
            if (dlr == DialogResult.Yes)
            {
                if (txtId.Text.Equals(""))
                {
                    MessageBox.Show("SELECT ID FOOD THAT YOU WANT TO DELETE");
                }
                else
                {
                    foodRepository.RemoveFood(Int32.Parse(txtId.Text));
                   
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadFoodList();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("SELECT ID FOOD THAT YOU WANT TO UPDATE");
            }
            else
            {
                formUpdateFood frmUpdateFood = new formUpdateFood(Int32.Parse(txtId.Text));
                frmUpdateFood.Show();
            }
        }
        private void dtgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            try
            {
                int foodId = Int32.Parse(txtSearchId.Text);
                LoadFoodListById(foodId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Search Food By ID:");
            }
        }
        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string foodName = txtSearchName.Text;
            if (foodName != "")
            {
                LoadFoodListByName(foodName);
            }
            else MessageBox.Show("Search Name Input can not be empty");
        }

        private void btnSearchType_Click(object sender, EventArgs e)
        {
            //string type = cmbSearchType.SelectedItem.ToString();
            int typeId = int.Parse(cmbSearchType.SelectedValue.ToString());
            if (cmbSearchType.SelectedItem.ToString() != null)
            {
                LoadFoodListByType(typeId);
            }
            else MessageBox.Show("You must choose Type!");
        }
        #endregion

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
