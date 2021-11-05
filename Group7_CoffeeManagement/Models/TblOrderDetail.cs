using System;
using System.Collections.Generic;

#nullable disable

namespace Group7_CoffeeManagement.Models
{
    public partial class TblOrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int FoodId { get; set; }
        public int Quantity { get; set; }

        public virtual TblFood Food { get; set; }
        public virtual TblOrder Order { get; set; }

        public bool HasSameFood (TblOrderDetail other)
        {
            return other.FoodId == FoodId;
        }

    }
}
