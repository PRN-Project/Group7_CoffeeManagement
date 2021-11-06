using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.ViewModel
{

    public enum TableStatus
    {
        Empty,
        NonEmpty
    }

    public class CoffeeTable
    {
        private List<TblOrderDetail> orderDetailList = new List<TblOrderDetail>();

        public TableStatus Status
        {
            get
            {
                if (orderDetailList == null || orderDetailList.Count == 0)
                {
                    return TableStatus.Empty;
                }
                else
                {
                    return TableStatus.NonEmpty;
                }
            }
        }

        public List<TblOrderDetail> OrderDetailList
        {
            get
            {
                return orderDetailList;
            }
            set
            {
                if (value == null)
                {
                    orderDetailList = new List<TblOrderDetail>();
                }
                else
                {
                    orderDetailList = value;
                }
            }
        }

        public TblTable Table { get; set; }

        public string TableName { get { return Table.Name; } }

        public CoffeeTable(TblTable tableId)
        {
            Table = tableId;
        }
    }
}
