namespace VendingMachine
{
    class Food : Product
    {
        private bool Vegetarian { get; set; }

        public Food(
            ushort id,
            string name,
            ushort price,
            double size,
            string sizeUnit,
            bool vegetarian,
            string usageInstructions) : base()
        {
            Id = id;
            Name = name;
            Price = price;
            Size = size;
            SizeUnit = sizeUnit;
            Vegetarian = vegetarian;
            UsageInstructions = usageInstructions;
        }

        public override string Examine()
        {
            return
                $"Id:\t\t{Id}\n" +
                $"Name:\t\t{Name}\n" +
                $"Price:\t\t{Price} kr\n" +
                $"Size:\t\t{Size} {SizeUnit}\n" +
                $"Vegetarian:\t{YesNo(Vegetarian)}\n" +
                $"How to use:\t{UsageInstructions}";
        }

        //public override string Use()
        //{
        //    return UsageInstructions;
        //}
    }
}
