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
        
        public TblRevenue GetRevenueOfDay(DateTime date)
        {
            return this.db.TblRevenues.SingleOrDefault(revenue => revenue.Date.Millisecond == date.Millisecond);
        }

        public IEnumerable<TblOrder> GetListOrderOfDay (DateTime date) => this.db.TblOrders.Where(order => order.DateTime.Date.Millisecond == date.Date.Millisecond).ToList();

        public void UpdateRevenue(DateTime day, int newAmount)
        {
            TblRevenue targetRevenue = this.db.TblRevenues.SingleOrDefault(revenue=> revenue.Date.Millisecond == day.Millisecond);
            if (targetRevenue == null)
            {
                targetRevenue = new TblRevenue();
                targetRevenue.Date = DateTime.Today;
                targetRevenue.Revenue = newAmount;
            } else
            {
                targetRevenue.Revenue += newAmount;
            }

            this.db.TblRevenues.Update(targetRevenue);
        }
    }
}
