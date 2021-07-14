namespace VendingMachine
{
    class Food : Product
    {
        public bool Vegetarian { get; set; }

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
            return "";
        }

        public override string Use()
        {
            return "";
        }
    }
}
