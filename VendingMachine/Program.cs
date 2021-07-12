using System;
using VendingMachine.Model;

namespace VendingMachine
{
    class Program
    {
        static void Main()
        {
            DrinkButNotProduct();
        }

        static void DrinkButNotProduct()
        {
            //Product product = new Product();
            Drink drink = new Drink(1, "Fanta", 15, 33, "cl", true, false);
            Drink drink2 = new Drink(2, "Cola", 30, 1.5, "L", true, true);
            Product[] products = new Product[2] { drink, drink2 };

            Console.WriteLine("\nToString List");
            foreach (Product item in products)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nInfo List");
            foreach (Product item in products)
            {
                Console.WriteLine(item.Info());
            }
            Console.WriteLine(MachineCoreFuncs.ReturnChange(1346));
        }
    }
}
