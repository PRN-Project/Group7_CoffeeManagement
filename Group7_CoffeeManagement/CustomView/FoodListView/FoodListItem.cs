using Group7_CoffeeManagement.CustomView.Abstraction;
using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group7_CoffeeManagement.CustomView.FoodListView
{
    public partial class FoodListItem : IItemView<TblFood>
    {
        private FoodListViewManager itemManager;
        public TblFood data { get; set; }

        public FoodListItem(TblFood data)
        {
            this.data = data;
            InitializeComponent();
            bindData(data);
            initEvents();
        }

        private void initEvents()
        {
            Click += onFocus;
            lbFood.Click += onFocus;
            btnAdd.Click += onFocus;
        }

        public void setOnBtnAddClick(EventHandler onBtnClick)
        {
            btnAdd.Click += onBtnClick;
        }

        public override void bindData(TblFood data)
        {
            lbFood.Text = data.FoodName;
        }

        public override void clearFocus()
        {
            BackColor = Color.White;
        }

        public override void onFocus(object sender, EventArgs e)
        {
            itemManager.changeFocus(this);
            BackColor = Color.AliceBlue;
        }

        public override void setManager(object manager)
        {
            itemManager = manager as FoodListViewManager;
        }

    }
}
