namespace VendingMachine
{
    class Drink : Product
    {
        public bool Carbonated { get; set; }

        public bool SugarFree { get; set; }

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
            return "";
        }

        public override string Use()
        {
            return "";
        }
    }
}
