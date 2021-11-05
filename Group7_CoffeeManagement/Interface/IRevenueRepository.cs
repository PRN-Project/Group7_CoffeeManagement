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
        public decimal GetRevenueOfDay(int day);
        public IEnumerable<TblOrder> GetListOrderOfDay(int day);
    }
}
