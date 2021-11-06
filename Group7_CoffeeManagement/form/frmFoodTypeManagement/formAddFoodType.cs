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

        private void formAddFoodType_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int foodTypeId = 0;
            string foodTypeName = null;
            try
            {
               if (foodTypeName == "")
                {
                    MessageBox.Show("Tên danh mục không được để trống");
                } else
                {
                    foodTypeName = txtName.Text;
                    TblFoodType ft = foodTypeRepo.GetFoodTypeByName(foodTypeName);
                    if (ft == null)
                    {
                        TblFoodType foodType = new TblFoodType
                        {
                            //FoodId = int.Parse(txtId.Text),
                            TypeId = foodTypeId,
                            Description = foodTypeName
                        };
                        foodTypeRepo.AddFoodType(foodType);
                        this.Close();
                    } else MessageBox.Show("Id has existed!");

                }              
            }
            catch (Exception ex)
            {
                if (ex is ArgumentNullException)
                    MessageBox.Show("Your input is null, ");
                else if (ex is FormatException)
                    MessageBox.Show("Your input is not in the correct format.");
                else
                    MessageBox.Show("Your input is invalid.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
