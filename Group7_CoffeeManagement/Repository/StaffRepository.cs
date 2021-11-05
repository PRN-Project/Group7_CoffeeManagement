using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;

namespace Group7_CoffeeManagement.Repository
{
    public class StaffRepository : IStaffRepository
    {
        public CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        public TblStaff GetStaffByID(int staffID) => this.db.TblStaffs.FirstOrDefault(item => item.UserId == staffID);
        public IEnumerable<TblStaff> GetStaffs() => this.db.TblStaffs.ToList();
        public void AddStaff(TblStaff newStaff)
        {
            this.db.TblStaffs.Add(newStaff);
            this.db.SaveChanges();
        }
        public void RemoveStaff(int staffID)
        {
            this.db.TblStaffs.Remove(this.db.TblStaffs.FirstOrDefault(item => item.UserId == staffID));
            this.db.SaveChanges();
        }
        public void UpdateStaff(TblStaff updatedStaff)
        {
            this.db.TblStaffs.Update(updatedStaff);
            this.db.SaveChanges();
        }
        public IEnumerable<TblStaff> GetStaffByName(string name) => this.db.TblStaffs.Where(staff => staff.Name.Contains(name)).ToList();
    }
}
