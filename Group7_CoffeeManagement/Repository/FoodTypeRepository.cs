using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.Repository
{
    class FoodTypeRepository
    {
        public List<TblFoodType> getCustomType()
        {
            List<TblFoodType> customType = new List<TblFoodType>();
            for (int i = 1; i < 3; i++)
            {
                customType.Add(new TblFoodType()
                {
                    TypeId = i,
                    Description = "Type " + i
                });
            }

            return customType;
        }
    }
}
