using Group7_CoffeeManagement.Utils;
using System;
using System.Collections.Generic;

#nullable disable

namespace Group7_CoffeeManagement.Models
{
    public partial class TblOrder
    {
        public TblOrder()
        {
            TblOrderDetails = new HashSet<TblOrderDetail>();
        }

        public int OrderId { get; set; }
        public int TableId { get; set; }
        public int UserId { get; set; }
        public DateTime DateTime { get; set; }
        public decimal TotalPrice { get; set; }

        public string DisplayedTotalPrice { get
            {
                return TotalPrice.ToDisplayText();
            } 
        }

        public virtual TblTable Table { get; set; }
        public virtual TblStaff User { get; set; }
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
    }
}
