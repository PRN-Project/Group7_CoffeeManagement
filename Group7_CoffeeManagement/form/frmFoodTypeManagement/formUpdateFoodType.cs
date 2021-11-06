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

        private TblFoodType beingUpdatedFoodType;

        public formUpdateFoodType(TblFoodType foodType)
        {
            this.beingUpdatedFoodType = foodType;
            InitializeComponent();
        }

        private void formUpdateFoodType_Load(object sender, EventArgs e)
        {
            txtName.Text = beingUpdatedFoodType.Description;
        }
         
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string foodTypeName = txtName.Text;
                if (foodTypeName == "")
                {
                    MessageBox.Show("Tên danh mục không được để trống");
                }
                else
                {
                    beingUpdatedFoodType.Description = foodTypeName;
                    foodTypeRepo.UpdateFoodType(beingUpdatedFoodType);
                    MessageBox.Show("Cập nhật danh mục thành công");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật danh mục. Error message: " + ex.Message);
            }
        }
    }
}
