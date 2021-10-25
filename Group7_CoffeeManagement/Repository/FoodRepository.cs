using Group7_CoffeeManagement.Interface;
using Group7_CoffeeManagement.Models;
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

        public TblFood GetFoodByID(int foodId) => db.TblFoods.FirstOrDefault(food => food.FoodId == foodId);
        public List<TblFood> GetFoodList() => db.TblFoods.ToList();
        public void AddFood(TblFood newFood)
        {      
            try
            {
                db.TblFoods.Add(newFood);
                db.SaveChanges();
                MessageBox.Show("Add Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Add Food In Menu");
            }
        }
        public void RemoveFood(int foodId)
        {
            try
            {
                TblFood food = db.TblFoods.FirstOrDefault(food => food.FoodId == foodId);
                if (food != null)
                {
                    db.TblFoods.Remove(food);
                    db.SaveChanges();
                }
                else MessageBox.Show("Not Found");         
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Remove Food In Menu");
            }
        }
        public void UpdateFood(TblFood food)
        {        
            try
            {
                db.TblFoods.Update(food);
                db.SaveChanges();
                MessageBox.Show("Update Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Update Food In Menu");
            }
        }
    }
}
