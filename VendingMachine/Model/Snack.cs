using System;

namespace VendingMachine.Model
{
    class Snack : Product
    {
        public double Size { get; set; }

        public string SizeUnit { get; set; }

        public bool SugarFree { get; set; }

        public Snack(ushort id, string name, ushort price, double size, string sizeUnit, bool sugarFree) : base(id, name, price)
        {
            Price = price;
            Size = size;
            SizeUnit = sizeUnit;
            SugarFree = sugarFree;
        }

        public override string Info()
        {
            return $"--- Snack Type ---\nId: {Id}\nName {Name}\nSize: {Size}{SizeUnit}\nSugarFree: {SugarFree}\n";
        }
    }
}
