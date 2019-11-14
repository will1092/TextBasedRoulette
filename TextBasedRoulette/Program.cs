using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TextBasedRoulette
{
    // **************************************************
    //
    // Title: Text-based Roulette
    // Description: A user interactive text-based game of roulette
    // Author: Williams, Cody
    // Dated Created: 11/10/2019
    // Last Modified: 11/12/2019
    //
    // ************************************************** 
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
            DisplayScreenHeader("\tRoulette Rules");

            Console.WriteLine("Place bets, based on where you think the ball may land.");

            Console.WriteLine();

            Console.WriteLine("Numbers can be bet on individually,");
            Console.WriteLine("or in groups of numbers.");

            Console.WriteLine();

            Console.WriteLine("Such groups of numbers are: ");

            Console.WriteLine();

            Console.WriteLine("\t* Even/Odd,");
            Console.WriteLine("\t* Red/Black,");
            Console.WriteLine("\t* 1-18/19-36,");
            Console.WriteLine("\t* columns,");
            Console.WriteLine("\t* dozens");

            Console.WriteLine();

            Console.WriteLine("The next page will describe each number group.");

            DisplayContinuePrompt();

            DisplayScreenHeader("Roulette Rules");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tEven/Odd");
            Console.WriteLine();
            Console.WriteLine("\t\tBet on whether the winning number will be even or odd.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tRed/Black");
            Console.WriteLine();
            Console.WriteLine("\t\tBet on the color of the winning number.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t1-18/19-36");
            Console.WriteLine();
            Console.WriteLine("\t\tBet on whether the winning number will be low (lower than 19) or high.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tColums");
            Console.WriteLine();
            Console.WriteLine("\t\tBet from which of the three columns will the winning numbers be.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tDozens");
            Console.WriteLine();
            Console.WriteLine("\t\tBet on one of the three dozen that are found on the table.");

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
