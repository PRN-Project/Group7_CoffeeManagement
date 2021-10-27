using BusinessModel;

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

namespace Group7_CoffeeManagement
{
    public partial class frmCoffeeManagement : Form
    {

        private ITableRepository tableRepository;
        public static BindingSource roleSource = frmLogin.roleSource;
        public static CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        public frmCoffeeManagement()
        {
            InitializeComponent();
            tableRepository = new TableRepository();
            loadTableList();
        }

         void loadTableList ()
        {
            IEnumerable<TblTable> tableList = tableRepository.GetTableList();
            foreach (TblTable table in tableList)
            {
                Button button = new Button() { Width = 100, Height = 100 };
                //button.Width = 75;
                //button.Height = 75;
                //button.Text = table.Name;
                //panelTables.Controls.Add(button);
                

                if (table.Status==0)
                {
                    button.BackColor = Color.White;
                    button.Text = table.Name +Environment.NewLine +"Empty";
                }
                else if (table.Status==1)
                {
                    button.BackColor = Color.LightPink;
                    button.Text = table.Name+Environment.NewLine + "available";
                }
                panelTables.Controls.Add(button);
            }

        }

        private void loadMenu ()
        {
            
        }

        private void panelTables_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)

        {

        }

        private void panelTables_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
