using System;
using System.Collections.Generic;

#nullable disable

namespace Group7_CoffeeManagement.Models
{
    public partial class TblFoodType
    {
        public TblFoodType()
        {
            TblFoods = new HashSet<TblFood>();
        }

        public int TypeId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TblFood> TblFoods { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
