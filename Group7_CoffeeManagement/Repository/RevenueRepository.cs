using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group7_CoffeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace Group7_CoffeeManagement.Interface
{
    public class RevenueRepository : IRevenueRepository
    {
        public CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        
        public TblRevenue GetRevenueOfDay(DateTime date)
        {
            return this.db.TblRevenues.SingleOrDefault(revenue => revenue.Date == date);
        }

        public IEnumerable<TblOrder> GetListOrderOfDay (DateTime date) => this.db.TblOrders.Include(order => order.User).Include(order => order.Table).Where(order => order.DateTime.Date == date).ToList();

        public void UpdateRevenue(TblOrder order)
        {
            TblRevenue targetRevenue = GetRevenueOfDay(order.DateTime);
            if (targetRevenue == null)
            {
                targetRevenue = new TblRevenue();
                targetRevenue.Date = DateTime.Today;
                targetRevenue.Revenue = order.TotalPrice;
                this.db.TblRevenues.Add(targetRevenue);
                this.db.SaveChanges();
            } else
            {
                targetRevenue.Revenue += order.TotalPrice;
                this.db.TblRevenues.Update(targetRevenue);
                this.db.SaveChanges();
            }
        }
    }
}
