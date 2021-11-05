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
    class FoodTypeRepository : IFoodTypeRepository
    {
        public List<TblFoodType> getCustomType()
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

            return customType;
        }

        public TblFoodType GetFoodTypeByID(int id)
        {
            using var context = new CoffeeStoreManagementContext();
            //TblFoodType foodType = context.TblFoodTypes.Find(id);
            TblFoodType foodType = context.TblFoodTypes.SingleOrDefault(i => i.TypeId == id);
            if (foodType != null)
            {
                return foodType;
            }
            else return null;
        }

        public IEnumerable<TblFoodType> GetFoodTypeList()
        {
            var ftList = new List<TblFoodType>();
            try
            {
                using var context = new CoffeeStoreManagementContext();
                ftList = context.TblFoodTypes.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ftList;
        }


        public void AddFoodType(TblFoodType food)
        {
            try
            {
                using var context = new CoffeeStoreManagementContext();
                context.TblFoodTypes.Add(food);
                context.SaveChanges();
                MessageBox.Show("Add Successfully");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemoveFoodType(int id)
        {
            try
            {
                TblFoodType foodType = GetFoodTypeByID(id);
                if (foodType != null)
                {
                    using var context = new CoffeeStoreManagementContext();
                    context.TblFoodTypes.Remove(foodType);
                    context.SaveChanges();
                }
                else MessageBox.Show("Not Found");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateFoodType(TblFoodType food)
        {
            try
            {
                TblFoodType ftObj = GetFoodTypeByID(food.TypeId);
                if (ftObj != null)
                {
                    using var context = new CoffeeStoreManagementContext();
                    context.TblFoodTypes.Update(food);
                    context.SaveChanges();
                    MessageBox.Show("Update Successfully");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<TblFoodType> GetFoodTypeListByName(string name)
        {
            IEnumerable<TblFoodType> ftList = null;
            try
            {
                using var context = new CoffeeStoreManagementContext();

                if (name is null || name == "")
                {
                    ftList = context.TblFoodTypes.ToList();
                }
                else
                {
                    ftList = context.TblFoodTypes.Where(f => f.Description.ToUpper().Contains(name.ToUpper())).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ftList;
        }

        public IEnumerable<TblFoodType> GetFoodTypeListByType(int id)
        {
            IEnumerable<TblFoodType> foodTypeList = null;
            try
            {
                using var context = new CoffeeStoreManagementContext();
                foodTypeList = context.TblFoodTypes.Where(f => f.TypeId == id).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return foodTypeList;
        }
   
        public IEnumerable<TblFoodType> GetAll()
        {
            using var context = new CoffeeStoreManagementContext();
            List<TblFoodType> list = context.TblFoodTypes.ToList();
            return list;
        }
    }
}
