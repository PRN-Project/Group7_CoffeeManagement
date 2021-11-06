using System;
using System.Collections.Generic;

#nullable disable

namespace Group7_CoffeeManagement.Models
{
    public partial class TblTable
    {
        public static readonly string ACTIVE_STATUS = "Hoạt động";

        public static readonly string INACTIVE_STATUS = "Ngừng";

        public TblTable()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        public int TableId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

        public string DisplayedStatus
        {
            get
            {
                if (Status == 0)
                {
                    return "Hoạt động";
                }
                else
                {
                    return "Ngừng";
                }
            }
        }

        public TblTable(int tableId, string name, int status)
        {
            TableId = tableId;
            Name = name;
            Status = status;
        }

        public virtual ICollection<TblOrder> TblOrders { get; set; }

        public static int getStatusCodeByStringValue(string stringStatus)
        {
            if (stringStatus.Equals(ACTIVE_STATUS))
            {
                return 0;
            }
            else if (stringStatus.Equals(INACTIVE_STATUS))
            {
                return 1;
            } else
            {
                throw new Exception("Unknown type status");
            }
        }
    }
}
