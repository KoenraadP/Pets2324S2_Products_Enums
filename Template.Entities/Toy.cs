using System;

namespace Pets.Entities
{
    public class Toy : Product
    {
        public ToySize ToySize { get; set; }

        public Toy()
        {

        }

        public Toy(Guid productId, string name, string description, decimal price, int amountInStock, AnimalType animalType, Brand brand, ToySize toySize) : base(productId, name, description, price, amountInStock, animalType, brand)
        {
            ToySize = toySize;
        }

        public Toy(Guid productId, string name, string description, decimal price, int amountInStock, AnimalType animalType, ToySize toySize) : base(productId, name, description, price, amountInStock, animalType)
        {
            ToySize = toySize;
        }
    }
}
