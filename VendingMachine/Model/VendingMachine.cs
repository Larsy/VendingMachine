using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class VendingMachine : IVending
    {
        private static readonly ushort[] denominations =
        {
            1, 5, 10, 20, 50, 100, 500, 1000
        };

        private static readonly Dictionary<ushort, ushort> change = new Dictionary<ushort, ushort>();

        private ushort balance = 0;

        public ushort Balance { get { return balance; } }

        public Product Purchase(ushort id)
        {
            int indexToFind;
            indexToFind = Array.FindIndex(Product.products, p => p.Id == id);
            if (balance >= Product.products[indexToFind].Price)
            {
                balance -= Product.products[indexToFind].Price;
                return Product.products[indexToFind];
            }
            else
            {
                return null;
            }
        }

        public Product[] ShowAll()
        {
            return Product.products;
        }
        
        public string InsertMoney(ushort amount)
        {
            if (Array.Exists(denominations, d => d == amount))
            {
                balance += amount;
                return $"Insert made: {amount} kr.";
            }
            else
            {
                return $"Insert attempt: {amount} kr.\nThe machine doesn't accept this money/denomination";
            }
        }
        public string EndTransaction(ushort amountToGetBack)
        {
            ushort amountLeftToReturn = amountToGetBack;
            ushort denominationCount;
            string output = "";

            while (amountLeftToReturn > 0)
            {
                for (int i = denominations.Length - 1; i >= 0; i--)
                {
                    if (amountLeftToReturn >= denominations[i])
                    {
                        denominationCount = (ushort)Math.Truncate((decimal)(amountLeftToReturn / denominations[i]));
                        change.Add(denominations[i], denominationCount);
                        amountLeftToReturn -= (ushort)(denominationCount * denominations[i]);
                    }
                }
            }
            foreach (KeyValuePair<ushort, ushort> kvp in change)
            {
                output += kvp.Key + " kr, " + kvp.Value + " st.\n";
            }
            return output;
        }

        public void AddProduct(Product productToAdd)
        {
            Array.Resize(ref Product.products, Product.products.Length + 1);
            Product.products[Product.products.Length - 1] = productToAdd;
        }
    }
}
