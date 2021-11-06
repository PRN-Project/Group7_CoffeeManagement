using BusinessModel;
using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.Repository
{
    public class TableRepository : ITableRepository

    {
        public static CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        public List<TblTable> mock_database;

        public TableRepository()
        {
            mock_database = new List<TblTable>();
            for (int i = 1; i <= db.TblTables.Count(); i++)
            {
                mock_database.Add(new TblTable(i-1,"Ban " + i,0));
            }
        }

        public TblTable GetTableByID(int tableId) => db.TblTables.FirstOrDefault(item => item.TableId == tableId);
        public IEnumerable<TblTable> GetTableByName(string name) => db.TblTables.Where(item => item.Name.Contains(name));
        public void AddTable(TblTable table)
        {
            db.TblTables.Add(table);
            db.SaveChanges();
        }


        public void DeleteTableById(int tableId)
        { 
            db.TblTables.Remove(db.TblTables.FirstOrDefault(item => item.TableId == tableId));
            db.SaveChanges();
        }

        public void DeleteTableByName(string name)
        {
            db.TblTables.Remove(db.TblTables.FirstOrDefault(item => item.Name == name));
            db.SaveChanges();
            
        }

        public List<TblTable> GetTableList()
        {
            List<TblTable> tableslist;
            try
            {
                tableslist = db.TblTables.ToList();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return tableslist;
        }

        public void UpdateTable(TblTable table)
        {
            db.TblTables.Update(table);
            db.SaveChanges();
        }

        public IEnumerable<TblTable> LoadTableByStatus(int status)
        {
            return db.TblTables.Where(table => table.Status == status);
        }
    }
}
