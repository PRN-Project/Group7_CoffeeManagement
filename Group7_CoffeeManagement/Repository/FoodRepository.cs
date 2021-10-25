using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.Repository
{
    class FoodRepository
    {
        public static CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        public TblFood GetFoodByID(int foodId) => db.TblFoods.FirstOrDefault(food => food.FoodId == foodId);
        public List<TblFood> GetFoodList() => db.TblFoods.ToList();
        public void AddFood(TblFood newFood)
        {
            db.TblFoods.Add(newFood);
            db.SaveChanges();
        }
        public void RemoveFood(int foodId)
        {
            db.TblFoods.Remove(db.TblFoods.FirstOrDefault(food => food.FoodId == foodId));
            db.SaveChanges();
        }
        public void UpdateFood(TblFood food)
        {
            db.TblFoods.Update(food);
            db.SaveChanges();
        }
    }
}
