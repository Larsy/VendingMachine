namespace VendingMachine
{
    public interface IVending
    {
        ushort Balance { get; }

        Product Purchase(ushort id);

        Product[] ShowAll();

        string InsertMoney(ushort amount);

        string EndTransaction(ushort amountToGetBack);

        void AddProduct(Product productToAdd);
    }
}
