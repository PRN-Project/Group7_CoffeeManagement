using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.Interface
{
    interface IOrderDetailRepository
    {
        void Add (TblOrderDetail orderDetail);

        void CheckOut (TblOrder order, List<TblOrderDetail> orderDetailList);

        IEnumerable<TblOrderDetail> getOrderDetailByOrderId(int orderId);
    }
}
