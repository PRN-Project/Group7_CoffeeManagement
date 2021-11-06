using Group7_CoffeeManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group7_CoffeeManagement
{
    public partial class frmChooseTargetForm : Form
    {
        private BindingSource bindingSource = new BindingSource();

        private frmCoffeeManagement formMain;

        private Dictionary<Button, CoffeeTable> tableDictionary;

        public frmChooseTargetForm(frmCoffeeManagement formMain, Dictionary<Button, ViewModel.CoffeeTable> availableTableList, Button currentChosenTable)
        {
            this.tableDictionary = availableTableList;
            this.formMain = formMain;
            InitializeComponent();
            dgvTable.DataSource = bindingSource;
            bindingSource.DataSource = availableTableList.Values;
            setUpDataGridView();
        }

        private void setUpDataGridView ()
        {
            dgvTable.Columns["TableName"].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 12F, GraphicsUnit.Point);

            dgvTable.Columns["Table"].Visible = false;
            //dgvTable.Columns["OrderDetailList"].Visible = false;
            dgvTable.Columns["Status"].Visible = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var targetTable = bindingSource.Current as CoffeeTable;
            if (targetTable == null)
            {
                MessageBox.Show("Vui lòng chọn bàn chuyển đến");
                return;
            }

            foreach (Button tableButton in tableDictionary.Keys)
            {
                if (tableButton.Text.Equals(targetTable.TableName))
                {
                    formMain.transferTable(tableButton);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
