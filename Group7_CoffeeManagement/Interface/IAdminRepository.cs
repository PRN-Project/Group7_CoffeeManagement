using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group7_CoffeeManagement.Models;

namespace Group7_CoffeeManagement.Interface
{
    public interface IAdminRepository
    {
        public List<TblStaff> GetStaffs();
        public void AddStaff(TblStaff newStaff);
        public void RemoveStaff(int staffID);
        public void UpdateStaff(TblStaff updatedStaff);
    }
}
