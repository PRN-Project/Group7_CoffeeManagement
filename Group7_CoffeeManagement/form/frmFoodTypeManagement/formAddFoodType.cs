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
    public partial class formAddFoodType : Form
    {
        private IFoodTypeRepository foodTypeRepo = new FoodTypeRepository();
        public formAddFoodType()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string foodTypeName = null;
            try
            {
                if (foodTypeName == "")
                {
                    MessageBox.Show("Tên danh mục không được để trống");
                }
                else
                {
                    foodTypeName = txtName.Text;
                    TblFoodType duplicateFoodType = foodTypeRepo.GetFoodTypeByName(foodTypeName);
                    if (duplicateFoodType == null)
                    {
                        TblFoodType foodType = new TblFoodType
                        {
                            Description = foodTypeName
                        };
                        foodTypeRepo.AddFoodType(foodType);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("\"" + foodTypeName + "\" đã tồn tại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi. Error message: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
