using Group7_CoffeeManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group7_CoffeeManagement.CustomView
{
    class TableListViewManager
    {
        List<Button> tableList = new List<Button>();

        public Button Current;

        public static readonly Color FOCUSED_COLOR = Color.IndianRed;

        public static readonly Color EMPTY_COLOR = Color.White;

        public static readonly Color NON_EMPTY_COLOR = Color.Blue;

        private Dictionary<Button, CoffeeTable> tableDictionary = new Dictionary<Button, CoffeeTable>();

        private bool thisTimeFocusEnable = true;
        public TableListViewManager()
        {
        }

        public void AddItem(Button button)
        {
            tableList.Add(button);
            button.Click += onFocus;
        }

        public void setTableDictionary(Dictionary<Button, CoffeeTable> tableDictionary)
        {
            this.tableDictionary = tableDictionary;
        }

        private void onFocus(object sender, EventArgs e)
        {

            if (thisTimeFocusEnable == true)
            {
                resetPreviousFocus();
                var button = sender as Button;
                Current = button;
                focus(button);
            }
            else
            {
                thisTimeFocusEnable = true;
            }
        }

        private void focus(Button button)
        {
            button.BackColor = FOCUSED_COLOR;
            button.ForeColor = Color.White;
        }

        public void disableFocusOnce ()
        {
            thisTimeFocusEnable = false;
        }

        private void resetPreviousFocus()
        {
            if (Current == null)
            {
                return;
            }

            if (getCoffeeTableByButton(Current).Status == TableStatus.Empty)
            {
                Current.BackColor = EMPTY_COLOR;
                Current.ForeColor = Color.Black;
            }
            else if (getCoffeeTableByButton(Current).Status == TableStatus.NonEmpty)
            {
                Current.BackColor = NON_EMPTY_COLOR;
                Current.ForeColor = Color.White;
            }
        }


        private CoffeeTable getCoffeeTableByButton(Button button)
        {
            return tableDictionary[button];
        }

        internal void CheckOut(Button currentChosenTable)
        {
            tableDictionary[currentChosenTable].OrderDetailList = null;
            currentChosenTable.BackColor = EMPTY_COLOR;
        }
    }
}
