using System;
using System.Collections.Generic;

#nullable disable

namespace Group7_CoffeeManagement.Models
{
    public partial class TblTable
    {
        public TblTable()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        public int TableId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

        public TblTable(int tableId, string name, int status)
        {
            TableId = tableId;
            Name = name;
            Status = status;
        }


        public virtual ICollection<TblOrder> TblOrders { get; set; }
    }
}
