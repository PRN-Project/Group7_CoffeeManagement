using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.Interface
{
    public interface IFoodTypeRepository
    {
        TblFoodType GetFoodTypeByID(int id);
        IEnumerable<TblFoodType> GetFoodTypeList();
        void AddFoodType(TblFoodType food);
        void RemoveFoodType(int id);
        void UpdateFoodType(TblFoodType food);
        IEnumerable<TblFoodType> GetFoodTypeListByName(string name);
        IEnumerable<TblFoodType> GetFoodTypeListByType(int typeId);
        IEnumerable<TblFoodType> GetAll();
        TblFoodType GetFoodTypeByName(string foodTypeName);
    }
}
