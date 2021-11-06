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
    public partial class formFoodManagement : Form
    {
        private IFoodRepository foodRepository = new FoodRepository();
        private IFoodTypeRepository foodTypeRepo = new FoodTypeRepository();
        private BindingSource bindingSource = new BindingSource();
        private readonly int TYPE_ALL = -100;

        public formFoodManagement()
        {
            InitializeComponent();
            getComboboxValue();
            cmbSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.VisibleChanged += onVisibleChanged;
        }

        private void onVisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                RefreshFoodList();
            }
        }

        #region methods

        public void getComboboxValue()
        {
            var foodTypeList = new List<TblFoodType>();
            foodTypeList.Add(new TblFoodType()
            {
                TypeId = TYPE_ALL,
                Description = "Tất cả"
            });

            foodTypeList.AddRange(foodTypeRepo.GetAll());
            cmbSearchType.DataSource = foodTypeList;
            cmbSearchType.DisplayMember = "Description";
            cmbSearchType.ValueMember = "TypeId";
        }

        public void RefreshFoodList()
        {
            try
            {
                var foods = foodRepository.GetFoodList();
                bindingSource.DataSource = foods;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đã xảy ra lỗi khi tải danh sách món ăn");
            }
        }
        

        public void AddFood()
        {
            formAddFood frm = new formAddFood();
            var addResult = frm.ShowDialog();
            if (addResult == DialogResult.OK)
            {
                RefreshFoodList();
            }
        }

        public void LoadFoodListByName(string name)
        {
            try
            {
                var foodList = foodRepository.GetFoodListByName(name);
                bindingSource.DataSource = foodList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đã xảy ra lỗi khi tìm kiếm");
            }
        }

        public void LoadFoodListByType(int typeId)
        {        
            try
            {
                var foodList = foodRepository.GetFoodListByType(typeId);
                bindingSource.DataSource = foodList;
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
                dtgvData.DataSource = bindingSource;

                bindingSource.DataSource = foods;
                setUpDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Load Food List");
            }
        }

        private void setUpDataGridView ()
        {
            this.dtgvData.AllowUserToAddRows = false;
            this.dtgvData.Columns["FoodId"].HeaderText = "Mã số";
            this.dtgvData.Columns["FoodName"].HeaderText = "Tên";
            this.dtgvData.Columns["DisplayedPrice"].HeaderText = "Giá";
            this.dtgvData.Columns["Type"].HeaderText = "Loại";

            this.dtgvData.Columns["TypeId"].Visible = false;
            this.dtgvData.Columns["Price"].Visible = false;
            this.dtgvData.Columns["TblOrderDetails"].Visible = false;

            this.dtgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dtgvData.ReadOnly = true;
            this.dtgvData.RowHeadersVisible = false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFood();
            RefreshFoodList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var current = bindingSource.Current as TblFood;
            if (current == null)
            {
                if (bindingSource.Count == 0)
                {
                    MessageBox.Show("Không có món ăn nào để cập nhật");
                } else
                {
                    MessageBox.Show("Vui lòng chọn 1 món ăn để cập nhật");
                }
            }
            else
            {
                formUpdateFood frmUpdateFood = new formUpdateFood(current.FoodId);
                var updateResult = frmUpdateFood.ShowDialog();
                if (updateResult == DialogResult.OK)
                {
                    RefreshFoodList();
                }
            }
        }
 
        #endregion


        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TblFoodType type = cmbSearchType.SelectedItem as TblFoodType;
            
            if (type.TypeId == TYPE_ALL)
            {
                RefreshFoodList();
                return;
            }

            if (cmbSearchType.SelectedItem.ToString() != null)
            {
                LoadFoodListByType(type.TypeId);
            }
            else MessageBox.Show("You must choose Type!");
        }

        private void txtSearchName_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = txtSearchName.Text;

            if (keyword.Length == 0)
            {
                RefreshFoodList();
            }
            else
            {
                LoadFoodListByName(keyword);
            }
        }
    }
}
