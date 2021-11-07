using System;
using System.Collections.Generic;

#nullable disable

namespace Group7_CoffeeManagement.Models
{
    public partial class TblStaff
    {
        public TblStaff()
        {
            TblOrders = new HashSet<TblOrder>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Role { get; set; }
        
        public string DisplayedRole { 
            get { if (Role == 0)
                    return "Quản trị viên";
                else
                    return "Nhân viên"; 
            } 
        }

        public virtual ICollection<TblOrder> TblOrders { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
