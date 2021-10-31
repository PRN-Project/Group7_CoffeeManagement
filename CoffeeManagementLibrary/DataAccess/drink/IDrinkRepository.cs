using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagementLibrary.DataAccess.drink
{
    public interface IDrinkRepository
    {
        IEnumerable<TblFood> LoadAllMenu();

    }
}
