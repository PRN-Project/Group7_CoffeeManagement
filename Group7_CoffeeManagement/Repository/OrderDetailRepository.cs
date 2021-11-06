using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.Repository
{
    class OrderDetailRepository : IOrderDetailRepository
    {
        private static CoffeeStoreManagementContext dbContext = new CoffeeStoreManagementContext();
        public void Add(TblOrderDetail orderDetail)
        {
            dbContext.TblOrderDetails.Add(orderDetail);
            dbContext.SaveChanges();
        }

        public void CheckOut(TblOrder order, List<TblOrderDetail> orderDetailList)
        {
            var clonedOrderDetail = new List<TblOrderDetail>();
            orderDetailList.ForEach(orderDetail =>
           {
               clonedOrderDetail.Add(new TblOrderDetail()
               {
                   OrderId = order.OrderId,
                   OrderDetailId = orderDetail.OrderDetailId,
                   FoodId = orderDetail.FoodId,
                   Quantity = orderDetail.Quantity
               });
           });

            dbContext.TblOrderDetails.AddRange(clonedOrderDetail);
            dbContext.SaveChanges();
        }
    }
}
