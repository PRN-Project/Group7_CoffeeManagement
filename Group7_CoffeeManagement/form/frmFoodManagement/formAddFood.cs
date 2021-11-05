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

namespace Group7_CoffeeManagement.form.frmFoodManagement
{
    public partial class formAddFood : Form
    {
        IFoodRepository foodRepositoty = new FoodRepository();
        private IFoodTypeRepository foodTypeRepo = new FoodTypeRepository();
        CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        public formAddFood()
        {
            InitializeComponent();
            getComboboxValue();
            int newId = foodRepositoty.GetLastId() + 1;
            txtId.Text = newId.ToString();
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            txtId.ReadOnly = true;
        }

        public void getComboboxValue()
        {
            cmbType.DataSource = foodTypeRepo.GetAll();
            cmbType.DisplayMember = "Description";
            cmbType.ValueMember = "TypeId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int foodTypeId =  int.Parse(cmbType.SelectedValue.ToString());              
                TblFood food = new TblFood
                {
                    //FoodId = int.Parse(txtId.Text),
                    FoodName = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    TypeId = foodTypeId,
                  
                };
                foodRepositoty.AddFood(food);
                //db.SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Add a member");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
