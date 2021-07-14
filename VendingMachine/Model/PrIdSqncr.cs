using System;

namespace VendingMachine.Model
{
    class PrIdSqncr
    {
        private static ushort productId = 0;
        public static ushort ProductId
        {
            get { return productId; }
        }
        public static ushort NxtPrdctId()
        {
            return productId++;
        }
        public static void Reset()
        {
            productId = 0;
        }
    }
}
