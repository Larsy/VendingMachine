using System;

namespace VendingMachine.Model
{
    abstract class Product
    {
        public ushort Id { get; set; }

        public string Name { get; set; }

        public ushort Price { get; set; }

        public abstract string Info();

        public Product (ushort id, string name, ushort price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public string Examine(ushort productId)
        {
            return productId.ToString();
        }

        public string Use(ushort productId)
        {
            return productId.ToString() ;
        }

        public override string ToString()
        {
            return $"Id: {Id}\tName: {Name}\tPrice: {Price}";
        }
    }
}
