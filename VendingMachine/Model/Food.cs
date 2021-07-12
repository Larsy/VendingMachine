using System;

namespace VendingMachine.Model
{
    class Food : Product
    {
        public double Size { get; set; }

        public string SizeUnit { get; set; }

        public bool Vegetarian { get; set; }

        public Food(ushort id, string name, ushort price, double size, string sizeUnit, bool vegetarian) : base(id, name, price)
        {
            Price = price;
            Size = size;
            SizeUnit = sizeUnit;
            Vegetarian = vegetarian;
        }

        public override string Info()
        {
            return $"--- Food Type ---\nId: {Id}\nName {Name}\nSize: {Size}{SizeUnit}\nVegetarian: {Vegetarian}\n";
        }
    }
}
