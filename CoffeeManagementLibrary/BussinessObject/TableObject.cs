using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    public class TableObject
    {
        public int TableID { get; set; }

        public string Name { get; set; }

        public int Status { get; set; }

        public TableObject (int tableId, string name, int status)
        {
            this.TableID = tableId;
            this.Name = name;
            this.Status = status;
        }
    }
}
