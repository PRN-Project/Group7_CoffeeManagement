using Group7_CoffeeManagement.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;

#nullable disable

namespace Group7_CoffeeManagement.Models
{
    public partial class TblFood
    {
        public TblFood()
        {
            TblOrderDetails = new HashSet<TblOrderDetail>();
        }

        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public int TypeId { get; set; }

        public string DisplayedPrice { get {
                return Price.ToDisplayText();    
            }
        }

        public virtual TblFoodType Type { get; set; }
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
    }
}
