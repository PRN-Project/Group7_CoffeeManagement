using System;
using System.Collections.Generic;

#nullable disable

namespace Group7_CoffeeManagement.Models
{
    public partial class TblRevenue
    {
        public int RevenueId { get; set; }
        public DateTime Date { get; set; }
        public decimal Revenue { get; set; }
    }
}
