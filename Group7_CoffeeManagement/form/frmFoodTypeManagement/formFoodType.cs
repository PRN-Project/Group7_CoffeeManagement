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
                dgvCategory.DataSource = null;
                dgvCategory.DataSource = bindingSource;
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
                dgvCategory.DataSource = null;
                dgvCategory.DataSource = bindingSource;
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
                dgvCategory.DataSource = null;
                dgvCategory.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load Product By Type");
            }
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
                dgvCategory.DataSource = null;
                dgvCategory.DataSource = bindingSource;
                //AddBiding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Load Food Type List");
            }
        }


        #endregion

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddFoodType();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            formUpdateFoodType frm = new formUpdateFoodType(Int32.Parse(txtId.Text));
            frm.Show();
        }
    }
}
