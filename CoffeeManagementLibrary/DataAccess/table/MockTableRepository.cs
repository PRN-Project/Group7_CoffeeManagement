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
            for (int i = 1; i <= 32; i++)
            {
                mock_database.Add(new TableObject(i - 1, "Bàn " + i, 0));
            }
        }

        public void AddTable(TableObject table)
        {
            
        }

        public void DeleteTableById(int tableId)
        {

        }

        public IEnumerable<TableObject> GetTableList()
        {
            return mock_database;
        }

        public void UpdateTable (TableObject table)
        {

        }

    }
}
