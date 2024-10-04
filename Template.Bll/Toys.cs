using System;
using System.Collections.Generic;
using Pets.Dal;
using Pets.Entities;

namespace Pets.Bll
{
    public static class Toys
    {
        public static List<Toy> Read()
        {
            return ToysDal.Read();
        }

        public static List<Toy> DogToys()
        {
            return ToysDal.DogToys();
        }

        public static List<Toy> CatToys()
        {
            return ToysDal.CatToys();
        }

        public static Toy Read(string id)
        {
            return Guid.TryParse(id, out var newGuid) ? ToysDal.Read(newGuid) : new Toy();
        }

        public static bool Create(string name, string description, AnimalType animalType, Brand brand, decimal price)
        {
            Toy toy = new Toy
            {
                ProductId = Guid.NewGuid(),
                Name = name,
                Description = description,
                AnimalType = animalType,
                Brand = brand,
                Price = price
            };
            return ToysDal.Create(toy);
        }
    }
}
