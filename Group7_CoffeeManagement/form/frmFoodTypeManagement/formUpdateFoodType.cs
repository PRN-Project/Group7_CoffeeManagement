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
    public partial class formUpdateFoodType : Form
    {
        IFoodTypeRepository foodTypeRepo = new FoodTypeRepository();
        int foodTypeId = 0;
        public formUpdateFoodType(int id)
        {
            foodTypeId = id;
            InitializeComponent();
            txtId.ReadOnly = true;
        }

        private void formUpdateFoodType_Load(object sender, EventArgs e)
        {
            TblFoodType foodType = foodTypeRepo.GetFoodTypeByID(foodTypeId);

            txtId.Text = foodType.TypeId.ToString();
            txtName.Text = foodType.Description;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int id = foodTypeId;
                string foodTypeName = txtName.Text;
                if (foodTypeName == "")
                {
                    MessageBox.Show("You must input name");
                }else
                {
                    TblFoodType foodType = new TblFoodType
                    {
                        TypeId = id,
                        Description = foodTypeName,
                    };
                    foodTypeRepo.UpdateFoodType(foodType);
                    //MessageBox.Show("Update Successfully!");
                    this.Close();
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
