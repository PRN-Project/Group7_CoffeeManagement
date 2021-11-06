using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.Interface
{
    public interface IFoodRepository
    {
        TblFood GetFoodByID( int id);
        IEnumerable<TblFood> GetFoodList();
        void AddFood(TblFood food);
        void RemoveFood(int id);
        void UpdateFood(TblFood food);

        int GetLastId();
        IEnumerable<TblFood> GetFoodListByName(string name);
        IEnumerable<TblFood> GetFoodListByType(int typeId);
    }
}
