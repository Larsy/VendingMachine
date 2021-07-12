using System;

namespace VendingMachine.Model
{
    class Drink : Product
    {
        public double Size { get; set; }

        public string SizeUnit { get; set; }

        public bool Carbonated { get; set; }

        public bool SugarFree { get; set; }

        public Drink (ushort id, string name, ushort price,  double size, string sizeuUnit, bool carbonated, bool sugarFree) : base(id, name, price)
        {
            Price = price;
            Size = size;
            SizeUnit = sizeuUnit;
            Carbonated = carbonated;
            SugarFree = sugarFree;
        }

        public override string Info()
        {
            return $"--- Drink Type ---\nId: {Id}\nPrice: {Price} kr\nName: {Name}\nSize: {Size}{SizeUnit}\nCarbonated: {Carbonated}\nSugarFree: {SugarFree}\n";
        }
    }
}
