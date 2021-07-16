namespace VendingMachine
{
    class Drink : Product
    {
        private bool Carbonated { get; set; }

        private bool SugarFree { get; set; }

        public Drink(
            ushort id,
            string name,
            ushort price,
            double size,
            string sizeUnit,
            bool carbonated,
            bool sugarFree,
            string usageInstructions) : base()
        {
            Id = id;
            Name = name;
            Price = price;
            Size = size;
            SizeUnit = sizeUnit;
            Carbonated = carbonated;
            SugarFree = sugarFree;
            UsageInstructions = usageInstructions;
        }

        public override string Examine()
        {
            return
                $"Id:\t\t{Id}\n" +
                $"Name:\t\t{Name}\n" +
                $"Price:\t\t{Price} kr\n" +
                $"Size:\t\t{Size} {SizeUnit}\n" +
                $"Carbonated:\t{YesNo(Carbonated)}\n" +
                $"Sugar Free:\t{YesNo(SugarFree)}\n" +
                $"How to use:\t{UsageInstructions}";
        }

        //public override string Use()
        //{
        //    return UsageInstructions;
        //}
    }
}
