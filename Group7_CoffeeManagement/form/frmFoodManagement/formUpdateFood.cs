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
        private IFoodTypeRepository foodTypeRepo = new FoodTypeRepository();
        int foodId = 0;
        public formUpdateFood(int id)
        {
            foodId = id;
            InitializeComponent();
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            getComboboxValue();
            txtId.ReadOnly = true;
        }
        public void getComboboxValue()
        {
            
            TblFood food = foodRepository.GetFoodByID(foodId);
            int id = food.TypeId;
            TblFoodType foodType = foodTypeRepo.GetFoodTypeByID(id);
            string value = foodType.Description.ToString();
            cmbType.DataSource = foodTypeRepo.GetAll();
            cmbType.DisplayMember = "Description";
            cmbType.ValueMember = "TypeId";
            cmbType.SelectedIndex = cmbType.FindStringExact(value);
            
        }


        private void formUpdateFood_Load(object sender, EventArgs e)
        {
            TblFood food = foodRepository.GetFoodByID(foodId);

            txtId.Text = food.FoodId.ToString();
            txtName.Text = food.FoodName;          
            txtPrice.Text = food.Price.ToString();
            
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
                int typeId = int.Parse(cmbType.SelectedValue.ToString());             
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
                MessageBox.Show("Cập nhật món ăn thành công");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
