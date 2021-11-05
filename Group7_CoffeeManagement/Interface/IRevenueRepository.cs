using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group7_CoffeeManagement.Models;

namespace Group7_CoffeeManagement.Interface
{
    public interface IRevenueRepository
    {
        public TblRevenue GetRevenueOfDay(DateTime date);

        public IEnumerable<TblOrder> GetListOrderOfDay(DateTime date);

        public void UpdateRevenue(DateTime date, int newAmount);
    }
}
