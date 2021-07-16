using System;

namespace VendingMachine
{
    public abstract class Product
    {
        public ushort Id { get; protected set; }

        protected string Name { get; set; }

        public ushort Price { get; protected set; }

        protected double Size { get; set; }

        protected string SizeUnit { get; set; }

        protected string UsageInstructions { get; set; }

        public string Use() { return UsageInstructions; }

        public abstract string Examine();

        protected string YesNo(bool truefalse)
        {
            return truefalse == true ? "Yes" : "No";
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
