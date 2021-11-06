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
        private CoffeeStoreManagementContext context;

        public FoodTypeRepository()
        {
            context = new CoffeeStoreManagementContext();
        }
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
            TblFoodType foodType = context.TblFoodTypes.SingleOrDefault(i => i.TypeId == id);
            if (foodType != null)
            {
                return foodType;
            }
            else return null;
        }

        public IEnumerable<TblFoodType> GetFoodTypeList()
        {
            return context.TblFoodTypes.ToList();
        }

        public void AddFoodType(TblFoodType food)
        {
            int nextId = getNextId();
            food.TypeId = nextId;
            context.TblFoodTypes.Add(food);
            context.SaveChanges();
            MessageBox.Show("Thêm danh mục thành công");
        }

        private int getNextId()
        {
            IEnumerable<TblFoodType> foodTypeList = GetFoodTypeList();
            if (foodTypeList.Count() == 0)
            {   
                return 1;
            } else
            {
                var idResult = 0;
                foreach (TblFoodType foodType in foodTypeList)
                {
                    if (foodType.TypeId > idResult)
                    {
                        idResult = foodType.TypeId;
                    }
                }

                return (idResult + 1);
            }
        }

        public void RemoveFoodType(int id)
        {
            TblFoodType foodType = GetFoodTypeByID(id);
            if (foodType != null)
            {
                context.TblFoodTypes.Remove(foodType);
                context.SaveChanges();
            }
            else MessageBox.Show("Not Found");
        }

        public void UpdateFoodType(TblFoodType food)
        {
            context.TblFoodTypes.Update(food);
            context.SaveChanges();
        }

        public IEnumerable<TblFoodType> GetFoodTypeListByName(string name)
        {
            IEnumerable<TblFoodType> ftList = null;
            if (name is null || name == "")
            {
                ftList = context.TblFoodTypes.ToList();
            }
            else
            {
                ftList = context.TblFoodTypes.Where(f => f.Description.ToUpper().Contains(name.ToUpper())).ToList();
            }
            return ftList;
        }

        public IEnumerable<TblFoodType> GetFoodTypeListByType(int id)
        {
            IEnumerable<TblFoodType> foodTypeList = null;
            foodTypeList = context.TblFoodTypes.Where(f => f.TypeId == id).ToList();
            return foodTypeList;
        }
   
        public IEnumerable<TblFoodType> GetAll()
        {
            List<TblFoodType> list = context.TblFoodTypes.ToList();
            return list;
        }

        public TblFoodType GetFoodTypeByName(string foodTypeName)
        {
            return context.TblFoodTypes.SingleOrDefault(foodType => foodType.Description.Equals(foodTypeName));
        }
    }
}
