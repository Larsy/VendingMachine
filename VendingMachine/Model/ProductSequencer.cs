using System;

namespace VendingMachine.Model
{
    class ProductSequencer
    {
        private static ushort productId = 0;
        public static ushort ProductId
        {
            get { return productId; }
        }
        public static ushort NextId()
        {
            return productId++;
        }
        public static void Reset()
        {
            productId = 0;
        }
    }
}
