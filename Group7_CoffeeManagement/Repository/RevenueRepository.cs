using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group7_CoffeeManagement.Models;

namespace Group7_CoffeeManagement.Interface
{
    public class RevenueRepository : IRevenueRepository
    {
        public CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        public decimal GetRevenueOfDay(int day)
        {
            return this.db.TblOrders.Where(order => order.DateTime.Day == day).ToList().Sum(order => order.TotalPrice);
        }
        public IEnumerable<TblOrder> GetListOrderOfDay(int day) => this.db.TblOrders.Where(order => order.DateTime.Day == day).ToList();
    }
}
