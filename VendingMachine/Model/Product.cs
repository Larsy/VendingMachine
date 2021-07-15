using System;

namespace VendingMachine
{
    public abstract class Product
    {
        public static Product[] products = new Product[0]; 

        public ushort Id { get; set; }

        public string Name { get; set; }

        public ushort Price { get; set; }

        public double Size { get; set; }

        public string SizeUnit { get; set; }

        public string UsageInstructions { get; set; }

        public abstract string Examine();

        public abstract string Use();

        public string YesNo(bool yesno)
        {
            return yesno == true ? "Yes" : "No";
        }

        public override string ToString()
        {
            return
                $"Id: {Id}\t" +
                $"Name: {Name}".PadRight(45) +
                $"{Size} {SizeUnit}\t" +
                $"Price: {String.Format("{0, 3}", Price)} kr";
        }
    }
}
