﻿using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.Interface
{
    public interface IFoodRepository
    {
        List<TblFood> GetFoodList();
    }
}
