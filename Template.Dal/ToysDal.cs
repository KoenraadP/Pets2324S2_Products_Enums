using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Pets.Entities;

namespace Pets.Dal
{
    public static class ToysDal
    {
        public static bool Create(Toy toy)
        {
            using (var db = new PetsDbContext())
            {
                db.Toys.Add(toy);
                return db.SaveChanges() > 0;
            }
        }

        public static List<Toy> Read()
        {
            using (var db = new PetsDbContext())
            {
                return db.Toys.ToList();
            }
        }

        public static List<Toy> DogToys()
        {
            using (var db = new PetsDbContext())
            {
                List<Toy> dogToyList = db.Toys.ToList().FindAll(x => x.AnimalType == AnimalType.Dog);
                return dogToyList;
            }
        }

        public static List<Toy> CatToys()
        {
            using (var db = new PetsDbContext())
            {
                List<Toy> catToyList = db.Toys.ToList().FindAll(x => x.AnimalType == AnimalType.Cat);
                return catToyList;
            }
        }

        public static Toy Read(Guid id)
        {
            using (var db = new PetsDbContext())
            {
                return db.Toys.Find(id);
            }
        }

        public static bool Update(Toy updatedToy)
        {
            using (var db = new PetsDbContext())
            {
                var oldToy = db.Toys.Find(updatedToy.ProductId);

                if (oldToy != null)
                {
                    oldToy.Name = updatedToy.Name;
                }

                return db.SaveChanges() > 0;
            }
        }

        public static bool Delete(Toy toy)
        {
            using (var db = new PetsDbContext())
            {
                db.Entry(toy).State = EntityState.Deleted;
                return db.SaveChanges() > 0;
            }
        }
    }
}
