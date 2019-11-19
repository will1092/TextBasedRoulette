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

            InstantiateResults();

            DisplayMainMenu();

            DisplayContinuePrompt();
        }



    class Result
    {
        public int number { get; set; }
        public string oddity { get; set; }
        public string color { get; set; }
        public string half { get; set; }
        public string column { get; set; }
        public string dozen { get; set; }

    }

        #region PROGRAM METHODS

        private static void SetTheme()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        // todo - create instantiateResulsts method to create each number
        //        object from the Result class
        public static void InstantiateResults()
        {
            Result number1 = new Result();
            number1.number = 1;
            number1.oddity = "odd";
            number1.color = "red";
            number1.half = "first";
            number1.column = "first";
            number1.dozen = "first";

            Result number2 = new Result();
            number2.number = 2;
            number2.oddity = "even";
            number2.color = "black";
            number2.half = "first";
            number2.column = "first";
            number2.dozen = "first";



        }

        private static void DisplayMainMenu()
        {
            string menuChoice;
            bool quitApplication = false;
            double cash = 0;
            double cashToAdd;

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
                        cashToAdd = DollarsToChips(cash);
                        cash = cash + cashToAdd;
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

        //
        // add user input dollars onto the table
        //
        public static double DollarsToChips(double cash)
        {
            double total;
            double cashToAdd;

            DisplayScreenHeader("Add more money to the table.");

            Console.Write("How much money would you like to add? ");
            cashToAdd = double.Parse(Console.ReadLine());       /// todo - Check for double, if not give feedback and loop

            total = cash + cashToAdd;

            Console.WriteLine($"{cashToAdd:C} has been added to your pool of betting money.");

            Console.WriteLine($"Your new total is {total:C}");

            DisplayContinuePrompt();

            return total;
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
