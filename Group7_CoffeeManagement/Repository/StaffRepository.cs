﻿using System;
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
        public static CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        public IEnumerable<TblStaff> GetStaffByName(string Name) => db.TblStaffs.Where(item => item.Name.Contains(Name)).ToList();
        public List<TblStaff> GetStaffs() => db.TblStaffs.ToList();
        public void AddStaff(TblStaff newStaff)
        {
            db.TblStaffs.Add(newStaff);
            db.SaveChanges();
        }
        public void RemoveStaff(int staffID)
        {
            db.TblStaffs.Remove(db.TblStaffs.FirstOrDefault(item => item.UserId == staffID));
            db.SaveChanges();
        }
        public void UpdateStaff(TblStaff updatedStaff)
        {
            db.TblStaffs.Update(updatedStaff);
            db.SaveChanges();
        }

        public TblStaff FindMemberByUserName(string username)
        {
            return db.TblStaffs.SingleOrDefault(user => user.UserName.Equals(username));
        }
    }
}
