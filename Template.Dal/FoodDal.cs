using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Pets.Entities;

namespace Pets.Dal
{
    public static class FoodDal
    {
        public static bool Create(Food food)
        {
            using (var db = new PetsDbContext())
            {
                db.Food.Add(food);
                return db.SaveChanges() > 0;
            }
        }

        public static List<Food> Read()
        {
            using (var db = new PetsDbContext())
            {
                return db.Food.ToList();
            }
        }

        public static List<Food> DogFoods()
        {
            using (var db = new PetsDbContext())
            {
                List<Food> dogFoodList = db.Food.ToList().FindAll(x => x.AnimalType == AnimalType.Dog);
                return dogFoodList;
            }
        }

        public static List<Food> CatFoods()
        {
            using (var db = new PetsDbContext())
            {
                List<Food> catFoodList = db.Food.ToList().FindAll(x => x.AnimalType == AnimalType.Cat);
                return catFoodList;
            }
        }

        public static Food Read(Guid id)
        {
            using (var db = new PetsDbContext())
            {
                return db.Food.Find(id);
            }
        }
        public static bool Update(Food updatedFood)
        {
            using (var db = new PetsDbContext())
            {
                var oldFood = db.Food.Find(updatedFood.ProductId);

                if (oldFood != null)
                {
                    oldFood.Name = updatedFood.Name;
                }

                return db.SaveChanges() > 0;
            }
        }
        public static bool Delete(Food food)
        {
            using (var db = new PetsDbContext())
            {
                db.Entry(food).State = EntityState.Deleted;
                return db.SaveChanges() > 0;
            }
        }
    }
}
