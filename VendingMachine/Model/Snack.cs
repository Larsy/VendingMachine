namespace VendingMachine
{
    class Snack : Product
    {
        public bool SugarFree { get; set; }

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
            return "";
        }

        public override string Use()
        {
            return "";
        }
    }
}
