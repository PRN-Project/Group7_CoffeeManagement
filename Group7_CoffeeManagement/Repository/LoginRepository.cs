﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group7_CoffeeManagement.Models;
using Group7_CoffeeManagement.Interface;

namespace Group7_CoffeeManagement.Repository
{
    public class LoginRepository : ILoginRepository
    {
        public CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        public TblStaff checkLogin(string username, string password)
            => this.db.TblStaffs.FirstOrDefault(item => username == item.UserName && password == item.Password);
    }
}
