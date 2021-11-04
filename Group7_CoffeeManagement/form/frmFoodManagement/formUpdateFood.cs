using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.Repository;
using System;

using System.Windows.Forms;

namespace Group7_CoffeeManagement.form.frmFoodManagement
{
    public partial class formUpdateFood : Form
    {
        IFoodRepository foodRepository = new FoodRepository();
        int foodId = 0;
        public formUpdateFood(int id)
        {
            foodId = id;
            InitializeComponent();
            txtId.ReadOnly = true;
        }

        
        private void formUpdateFood_Load(object sender, EventArgs e)
        {
            TblFood food = foodRepository.GetFoodByID(foodId);

            txtId.Text = food.FoodId.ToString();
            txtName.Text = food.FoodName;          
            txtPrice.Text = food.Price.ToString();
            if (food.TypeId == 1)
            {
                //cmbType.SelectedText = "Drink";
                cmbType.SelectedItem = "Drink";
            }
            else 
            {
                //cmbType.SelectedText = "FastFood";
                cmbType.SelectedItem = "FastFood";
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
            
            try
            {
                int id = foodId;
                int typeId = 0;
                if (cmbType.SelectedItem.ToString().Equals("Drink"))
                {
                    typeId = 1;
                }
                else if (cmbType.SelectedItem.ToString().Equals("FastFood"))
                {
                    typeId = 2;
                }

                string foodName = txtName.Text;
                decimal foodPrice = decimal.Parse(txtPrice.Text);

                TblFood food = new TblFood
                {
                    FoodId = id,
                    FoodName = foodName,
                    Price = foodPrice,
                    TypeId = typeId
                };
                foodRepository.UpdateFood(food);
                //MessageBox.Show("Update Successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
