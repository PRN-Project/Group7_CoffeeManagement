using BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.table
{
    public class MockTableRepository : ITableRepository
    {

        private List<TableObject> mock_database;

        public MockTableRepository ()
        {
            mock_database = new List<TableObject>();
            mock_database.Add(new TableObject(0, "Bàn 1", 0));
            mock_database.Add(new TableObject(1, "Bàn 2", 0));
            mock_database.Add(new TableObject(2, "Bàn 3", 0));
        }

        public void AddTable(TableObject table)
        {
            
        }

        public void DeleteTableById(int tableId)
        {

        }

        public IEnumerable<TableObject> LoadTableList()
        {
            return mock_database;
        }

        public void UpdateTable (TableObject table)
        {

        }

    }
}
