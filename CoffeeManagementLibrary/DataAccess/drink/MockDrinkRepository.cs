using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagementLibrary.DataAccess.drink
{
    public class MockDrinkRepository : IDrinkRepository
    {
        private List<TblFood> menu = new List<TblFood>();

        public IEnumerable<TblFood> LoadAllMenu()
        {
            return menu;
        }

        public MockDrinkRepository()
        {
            List<TblFoodType> customType = new List<TblFoodType>();
            for (int i = 0; i < 3; i++)
            {
                customType.Add(new TblFoodType()
                {
                    TypeId = i,
                    Description = "Type " + i
                });
            }

            for (int i = 1; i <= 15; i++)
            {
                menu.Add(new TblFood()
                {
                    FoodId = i,
                    FoodName = "Drink " + i,
                    Price = i * 2200,
                    TypeId = customType[i % 3].TypeId
                });
            }
        }
    }
}
