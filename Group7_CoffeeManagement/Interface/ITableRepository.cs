using BusinessModel;
using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.Interface
{
    public interface ITableRepository
    {

        public IEnumerable<TblTable> GetTableList();
        public void AddTable(TblTable table);

        
        public void DeleteTableById(int tableId);

        public void UpdateTable(TblTable table);
    }
}
