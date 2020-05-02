using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Backend
{
    class BackEndController
    {
        private List<FoodStock> shoppingList = new List<FoodStock>();
        private StockEntryOverMenu stockEntryOverMenu = new StockEntryOverMenu();

        public FoodStock CreateFoodStockEntry()
        {
            FoodStock item = new FoodStock();
            Console.WriteLine("Type in a Name of stock: ");
            item.Name = Console.ReadLine();

            Console.WriteLine($"Type in an Amount of {item.Name} stock: ");
            item.Amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Type in a Price of {item.Name} stock: ");
            item.Price = Convert.ToDouble(Console.ReadLine());

            item.TotalPrice = item.Amount * item.Price;
            Console.WriteLine($"Total price is {item.TotalPrice} of {item.Name} {item.Amount}.");

            return item;
        }

        public void init() {
            stockEntryOverMenu.GetStockEntryOverMenuAnswere();

        }
        public void PrintInfoAboutStock(FoodStock item) {

            Console.WriteLine($"Name: {item.Name} | Amount: {item.Amount} | Price: {item.Price} | TotalPrice: {item.TotalPrice}");
        }
    }
}
