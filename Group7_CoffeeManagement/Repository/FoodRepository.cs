using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group7_CoffeeManagement.Repository
{
    class FoodRepository : IFoodRepository
    {
        public static CoffeeStoreManagementContext db = new CoffeeStoreManagementContext();
        
        public TblFood GetFoodByID(int foodId)
        {
            using var context = new CoffeeStoreManagementContext();
            TblFood food = context.TblFoods.Include(food => food.Type).SingleOrDefault(food => food.FoodId == foodId); 
            if (food != null)
            {             
                return food;
            }
            else return null;           

        }
       // public List<TblFood> GetFoodList() => db.TblFoods.ToList();

        public IEnumerable<TblFood> GetFoodList()
        {
            var foodList = new List<TblFood>();
            try
            {
                using var context = new CoffeeStoreManagementContext();
                foodList = context.TblFoods.Include(food => food.Type).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return foodList;
        }

        public void AddFood(TblFood newFood)
        {      
            try
            {
                db.TblFoods.Add(newFood);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }
        public void RemoveFood(int foodId)
        {
            try
            {
                TblFood food = GetFoodByID(foodId);
                if (food != null)
                {
                    db.TblFoods.Remove(food);
                    db.SaveChanges();
                }
                else MessageBox.Show("Not Found");         
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateFood(TblFood food)
        {        
            try
            {
                TblFood foodObj = GetFoodByID(food.FoodId);
                if (foodObj != null)
                {
                    using var context = new CoffeeStoreManagementContext();
                    context.TblFoods.Update(food);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int GetLastId()
        {
            IEnumerable<TblFood> FoodList = GetFoodList();
            if (FoodList.Count() > 0)
            {
                TblFood food = FoodList.Last();
                return food.FoodId;
            }
            else return 0;
        }

        public IEnumerable<TblFood> GetFoodListByName(string productName)
        {
            IEnumerable<TblFood> foodList = null;
            try
            {
                using var context = new CoffeeStoreManagementContext();

                if (productName is null || productName == "")
                {
                    foodList = context.TblFoods.ToList();
                }
                else
                {
                    foodList = context.TblFoods.Include(f => f.Type).Where(f => f.FoodName.ToUpper().Contains(productName.ToUpper())).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return foodList;
        }

        public IEnumerable<TblFood> GetFoodListByType(int id)
        {
            IEnumerable<TblFood> foodList = null;
            try
            {
                using var context = new CoffeeStoreManagementContext(); 
                foodList = context.TblFoods.Include(f => f.Type).Where(f => f.TypeId == id).ToList();             
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return foodList;
        }

    }


}
