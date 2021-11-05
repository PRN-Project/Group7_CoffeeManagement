using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.Repository
{
    class OrderRepository : IOrderRepository
    {
        private static CoffeeStoreManagementContext dbContext = new CoffeeStoreManagementContext();

        public void Add(TblOrder order)
        {
            dbContext.TblOrders.Add(order);
            dbContext.SaveChanges();
        }
    }
}
