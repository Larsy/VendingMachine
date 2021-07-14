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
            IVending machine = new VendingMachine();
            machine.AddProduct(new Drink(PrIdSqncr.NxtPrdctId(), "Fanta", 15, 33, "cl", true, false, "Just open and drink it"));
            machine.AddProduct(new Drink(PrIdSqncr.NxtPrdctId(), "Cola", 30, 1.5, "L", true, true, "Drink it \"On the rocks\""));
            machine.AddProduct(new Food(PrIdSqncr.NxtPrdctId(), "Köttbullsbaguette", 35, 500, "g", true, "Just friggin eat it!"));
            machine.AddProduct(new Food(PrIdSqncr.NxtPrdctId(), "Ägg & Falukorvsmörgås", 40, 400, "g", true, "Just friggin eat this too!"));
            machine.AddProduct(new Snack(PrIdSqncr.NxtPrdctId(), "Jordnötter", 30, 150, "g", true, "Avoid if allergic to nuts"));
            machine.AddProduct(new Snack(PrIdSqncr.NxtPrdctId(), "Snickers", 6, 1, "bit", true, "Don't eat too many. They're high carb!"));

            Product[] produkterna = machine.ShowAll();
            Console.WriteLine("\nAvailable Products");
            foreach (Product item in produkterna)
            {
                Console.WriteLine(item);
            }
        }
    }
}
