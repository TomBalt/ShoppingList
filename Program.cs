using ShoppingList.Backend;
using ShoppingList.Gui;
using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("STarting to work;");
            BackEndController backEndController = new BackEndController();
            StockEntryOverMenu stockEntryOverMenu = new StockEntryOverMenu();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Render();
            // FoodStock item = backEndController.CreateFoodStockEntry();
            //backEndController.PrintInfoAboutStock(item);

            Console.ReadKey();
        }
    }
}
