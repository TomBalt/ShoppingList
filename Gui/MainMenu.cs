using ShoppingList.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Gui
{
    class MainMenu : Window
    {

        private TextBlock titleTextBlock;
        private BackEndController backEndController;
        private StockEntryOverMenu stockEntryOverMenu;
        private bool continueToRunProgram = true;
        private bool playAgain = true;

        public MainMenu() : base(0, 0, 120, 30, '%')
        {

            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Press N to create new shopping list.","Press H to load history shopping list.", "Press Q to Quit." });
            backEndController = new BackEndController();
            stockEntryOverMenu = new StockEntryOverMenu();
        }

        public override void Render()
        {
            do
            {
                Console.Clear();

                base.Render();

                titleTextBlock.Render();

                ChooseMainMenuOption();
                if (continueToRunProgram)
                {
                    Console.Clear();
/*
                    playAgain = true;

                    while (playAgain)
                    {
                        ChooseGameOverOption();
                    }
                    */
                }
            } while (continueToRunProgram);
        }


        private void ChooseGameOverOption()
        {
            bool notValidKeyPress = true;
            do
            {
                stockEntryOverMenu.Render();
                
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.N:
                        // backEndController.AddNEwEntry();
                        Console.WriteLine("Creating a new list...");
                            notValidKeyPress = false;   
                            break;
                        case ConsoleKey.H:
                        //backEndController.LoadHistoryShoppingfile();
                        Console.WriteLine("Loading History files");
                        notValidKeyPress = false;
                        playAgain = false;
                            break;
                        case ConsoleKey.Q:
                        Console.WriteLine("Quiting...");
                            playAgain = false;
                            continueToRunProgram = false;
                            notValidKeyPress = false;
                            break;
                    }
                
            } while (notValidKeyPress);
        }
        private void ChooseMainMenuOption()
        {
            bool notValidKeyPress = true;

            do
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();

                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.N:
                            // backEndController.AddNEwEntry();
                            Console.WriteLine("Creating a new list...");
                            notValidKeyPress = false;
                            Console.ReadKey();
                            break;
                        case ConsoleKey.H:
                            //backEndController.LoadHistoryShoppingfile();
                            Console.WriteLine("Loading History files");
                            notValidKeyPress = false;
                            Console.ReadKey();
                            break;
                        case ConsoleKey.Q:
                            Console.WriteLine("Quiting...");
                            Console.ReadKey();
                            continueToRunProgram = false;
                            notValidKeyPress = false;
                            break;
                    }
                }
            } while (notValidKeyPress);
        }
    }
}
