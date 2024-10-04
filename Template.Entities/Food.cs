using System.ComponentModel.DataAnnotations;
using System;

namespace Pets.Entities
{
    public class Food : Product
    {
        // extra properties enkel voor Food
        [Required]
        public double Weight { get; set; }
        // AgeCategory is een enum
        public AgeCategory AgeCategory { get; set; }

        public Food()
        {

        }

        public Food(Guid productId, string name, string description, decimal price, int amountInStock, AnimalType animalType, Brand brand, double weight, AgeCategory ageCategory) : base(productId, name, description, price, amountInStock, animalType, brand)
        {
            Weight = weight;
            AgeCategory = ageCategory;
        }

        public Food(Guid productId, string name, string description, decimal price, int amountInStock, AnimalType animalType, double weight, AgeCategory ageCategory) : base(productId, name, description, price, amountInStock, animalType)
        {
            Weight = weight;
            AgeCategory = ageCategory;
        }
    }
}
