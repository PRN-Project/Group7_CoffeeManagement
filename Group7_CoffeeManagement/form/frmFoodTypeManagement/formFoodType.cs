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
    public partial class formFoodType : Form
    {
        private IFoodTypeRepository foodTypeRepo = new FoodTypeRepository();
        private BindingSource bindingSource;
        public formFoodType()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            this.dgvCategory.DataSource = bindingSource;
            RefreshFoodTypeList();
            setUpDataGridview();
        }

        #region methods
        public void RefreshFoodTypeList()
        {
            try
            {
                var foodTypeList = foodTypeRepo.GetFoodTypeList();
                bindingSource.DataSource = foodTypeList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xảy ra lỗi khi tải danh mục");
            }
        }

        public void LoadFoodTypeListByName(string name)
        {
            try
            {
                var foodType = foodTypeRepo.GetFoodTypeListByName(name);
                bindingSource.DataSource = foodType;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load Food Type By Name");
            }
        }

        #endregion

        #region events
        private void formFoodTypeMangement_Load(object sender, EventArgs e)
        {
            try
            {
                var foodTypes = foodTypeRepo.GetFoodTypeList();
                bindingSource.DataSource = foodTypes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xảy ra lỗi khi tải danh mục");
            }
        }

        private void setUpDataGridview()
        {
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.Columns["TypeId"].Visible = false;
            this.dgvCategory.Columns["TblFoods"].Visible = false;
            this.dgvCategory.Columns["Description"].HeaderText = "Tên";
            this.dgvCategory.Columns["Description"].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 12F, GraphicsUnit.Point); 
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAddFoodType frm = new formAddFoodType();
            var addResult = frm.ShowDialog();
            if (addResult == DialogResult.OK)
            {
                RefreshFoodTypeList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var chosenFoodType = bindingSource.Current as TblFoodType;
            if (chosenFoodType != null)
            {
                formUpdateFoodType frm = new formUpdateFoodType(chosenFoodType);
                var updateResult = frm.ShowDialog();
                if (updateResult == DialogResult.OK)
                {
                    RefreshFoodTypeList();
                }
            }  else
            {
                MessageBox.Show("Bạn phải chọn một danh mục để cập nhật", "Chú ý");
            }
           
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchName.Text;

            if (keyword.Length > 0)
            {
                LoadFoodTypeListByName(keyword);

            } else
            {
                RefreshFoodTypeList();
            }
        }
    }
}
