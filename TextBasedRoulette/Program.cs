using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TextBasedRoulette
{
    class Program
    {
        static void Main(string[] args)
        {

            SetTheme();

            DisplayMainMenu();

            DisplayContinuePrompt();
        }

        private static void SetTheme()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        private static void DisplayMainMenu()
        {
            string menuChoice;
            bool quitApplication = false;

            do
            {

                DisplayScreenHeader("Main Menu");

                //
                // get the user's menu choice
                //
                Console.WriteLine("a) View Rules - WIP");
                Console.WriteLine("b) Add Money to Pool - WIP");
                Console.WriteLine("c) Place Bet - WIP");
                Console.WriteLine("d) Remove Bet - WIP");
                Console.WriteLine("e) Spin the Wheel - WIP");
                Console.WriteLine("f) Collect (Save Money to file) - WIP");
                Console.WriteLine("q) Quit");
                Console.Write("Enter Choice: ");
                menuChoice = Console.ReadKey().Key.ToString().ToLower().Trim();


                //
                // process user's choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayRulesTextWall();
                        break;

                    case "b":

                        break;
                    case "c":

                        break;

                    case "d":

                        break;

                    case "e":

                        break;

                    case "f":

                        break;

                    case "q":
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine("\t**********************");
                        Console.WriteLine("\tPlease indicate your choice with a letter.");
                        Console.WriteLine("\t**********************");

                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }


        #region PROGRAM METHODS

        //
        // display rules of roulette
        // 
        public static void DisplayRulesTextWall()
        {
            DisplayScreenHeader("Roulette Rules");



            DisplayContinuePrompt();
        }

        #endregion

        #region HELPER METHODS

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}
