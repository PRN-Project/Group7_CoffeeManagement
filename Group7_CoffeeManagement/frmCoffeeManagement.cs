using BusinessModel;
using DataAccess.table;
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
    public partial class frmCoffeeManagement : Form
    {

        private ITableRepository tableRepository;

        public frmCoffeeManagement()
        {
            InitializeComponent();
            tableRepository = new MockTableRepository();
            loadTableList();
        }

        private void loadTableList ()
        {
            IEnumerable<TableObject> tableList = tableRepository.GetTableList();
            foreach (TableObject table in tableList)
            {
                Button button = new Button();
                button.Width = 75;
                button.Height = 75;
                button.Text = table.Name;
                panelTables.Controls.Add(button);
            }
        }

        private void loadMenu ()
        {
            
        }

        private void panelTables_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTables_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
