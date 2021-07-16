namespace VendingMachine
{
    class Snack : Product
    {
        private bool SugarFree { get; set; }

        public Snack(
            ushort id,
            string name,
            ushort price,
            double size,
            string sizeUnit,
            bool sugarFree,
            string usageInstructions) : base()
        {
            Id = id;
            Name = name;
            Price = price;
            Size = size;
            SizeUnit = sizeUnit;
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
                $"Sugar Free:\t{YesNo(SugarFree)}\n" +
                $"How to use:\t{UsageInstructions}";
        }

        //public override string Use()
        //{
        //    return UsageInstructions;
        //}
    }
}
