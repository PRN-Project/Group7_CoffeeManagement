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
        ITableRepository TableRepository = new TableRepository();
        private ITableRepository tableRepository;
        public static BindingSource roleSource = frmLogin.roleSource;
        public static CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        string tagtext = null;

        public frmCoffeeManagement()
        {
            InitializeComponent();
            
        }

         void loadTableList ()
        {
           
            List<TblTable> tableList = tableRepository.GetTableList();
            if (true)
            {

            }
            foreach (TblTable table in tableList)
            {
                Button button = new Button() { Width = 100, Height = 100 };
               
                if (table.Status==0)
                {
                    button.BackColor = Color.White;
                    button.Text = table.Name +Environment.NewLine + "available"; 
                   // button.Text= "Empty";
                }
                else if (table.Status==1)
                {
                    button.BackColor = Color.LightPink;
                    button.Text = table.Name +Environment.NewLine + "unavailable"; 
                }
                button.MouseDown += new MouseEventHandler(bt_MouseDown);
                
                panelTables.Controls.Add(button);
            }
        }

        private void bt_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;// Lay button dang dc click
            tagtext = ((Button)sender).Text;
           

           // if (e.Button==MouseButtons.Left)
           // {
          //      MessageBox.Show(btn.Tag.ToString());
           // }
             if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(btn, e.Location);
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

        

        private void frmCoffeeManagement_Load(object sender, EventArgs e)
        {
            tableRepository = new TableRepository();
            loadTableList();
        }

        private void changeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban muon doi trang thai " + tagtext);
          

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTables.AutoScroll = true;
            MessageBox.Show("Ban muon xoa " + tagtext.Remove(5));
            tableRepository.DeleteTableByName(tagtext.Remove(5));
            deleteLoadedButton();
            frmCoffeeManagement_Load(sender, e);
        }
        void deleteLoadedButton()
        {
            foreach (Control item in panelTables.Controls.OfType<Button>().ToList())
            {
                panelTables.Controls.Remove(item);
                item.Dispose();
               
            }
        }
        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ban muon sua " + tagtext.Remove(5));
            
           // tableRepository.UpdateTable(update);
        }
    }
}
