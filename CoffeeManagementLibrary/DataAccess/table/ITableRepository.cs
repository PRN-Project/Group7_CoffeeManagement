using BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.table
{
    public interface ITableRepository
    {
        IEnumerable<TableObject> GetTableList();

        void AddTable(TableObject table);

        void DeleteTableById(int tableId);

        void UpdateTable(TableObject table);

    }
}
