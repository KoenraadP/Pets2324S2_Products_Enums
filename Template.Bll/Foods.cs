using System;
using System.Collections.Generic;
using Pets.Dal;
using Pets.Entities;

namespace Pets.Bll
{
    public static class Foods
    {
        public static List<Food> Read()
        {
            return FoodDal.Read();
        }

        public static List<Food> DogFoods()
        {
            return FoodDal.DogFoods();
        }

        public static List<Food> CatFoods()
        {
            return FoodDal.CatFoods();
        }

        public static Food Read(string id)
        {
            return Guid.TryParse(id, out var newGuid) ? FoodDal.Read(newGuid) : new Food();
        }

        public static bool Create(string name, string description, Animal animal, Brand brand, decimal price)
        {
            Food food = new Food
            {
                ProductId = Guid.NewGuid(),
                Name = name,
                Description = description,
                Animal = animal,
                Brand = brand,
                Price = price
            };
            return FoodDal.Create(food);
        }
    }
}
