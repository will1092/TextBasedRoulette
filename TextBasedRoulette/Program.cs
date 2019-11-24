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
    // Last Modified: 11/22/2019
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

        #region PROGRAM METHODS

        private static void SetTheme()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        public static void InstantiateResults()
        {
            List<Result> results = new List<Result>();

            //
            // instantiate results
            //
            #region NEWRESULTS
            Result number1 = new Result();
            Result number2 = new Result();
            Result number3 = new Result();
            Result number4 = new Result();
            Result number5 = new Result();
            Result number6 = new Result();
            Result number7 = new Result();
            Result number8 = new Result();
            Result number9 = new Result();
            Result number10 = new Result();
            Result number11 = new Result();
            Result number12 = new Result();
            Result number13 = new Result();
            Result number14 = new Result();
            Result number15 = new Result();
            Result number16 = new Result();
            Result number17 = new Result();
            Result number18 = new Result();
            Result number19 = new Result();
            Result number20 = new Result();
            Result number21 = new Result();
            Result number22 = new Result();
            Result number23 = new Result();
            Result number24 = new Result();
            Result number25 = new Result();
            Result number26 = new Result();
            Result number27 = new Result();
            Result number28 = new Result();
            Result number29 = new Result();
            Result number30 = new Result();
            Result number31 = new Result();
            Result number32 = new Result();
            Result number33 = new Result();
            Result number34 = new Result();
            Result number35 = new Result();
            Result number36 = new Result();
            #endregion NEWRESULTS

            //
            // set results property values
            //
            #region RESULTSPROPERTIES
            number1.number = 1;
            number1.oddity = "odd";
            number1.color = "red";
            number1.half = "first";
            number1.column = "first";
            number1.dozen = "first";

            number2.number = 2;
            number2.oddity = "even";
            number2.color = "black";
            number2.half = "first";
            number2.column = "second";
            number2.dozen = "first";

            number3.number = 3;
            number3.oddity = "odd";
            number3.color = "red";
            number3.half = "first";
            number3.column = "third";
            number3.dozen = "first";

            number4.number = 4;
            number4.oddity = "even";
            number4.color = "black";
            number4.half = "first";
            number4.column = "first";
            number4.dozen = "first";

            number5.number = 5;
            number5.oddity = "odd";
            number5.color = "red";
            number5.half = "first";
            number5.column = "second";
            number5.dozen = "first";

            number6.number = 6;
            number6.oddity = "even";
            number6.color = "black";
            number6.half = "first";
            number6.column = "third";
            number6.dozen = "first";

            number7.number = 7;
            number7.oddity = "odd";
            number7.color = "red";
            number7.half = "first";
            number7.column = "first";
            number7.dozen = "first";

            number8.number = 8;
            number8.oddity = "even";
            number8.color = "black";
            number8.half = "first";
            number8.column = "second";
            number8.dozen = "first";

            number9.number = 9;
            number9.oddity = "odd";
            number9.color = "red";
            number9.half = "first";
            number9.column = "third";
            number9.dozen = "first";

            number10.number = 10;
            number10.oddity = "even";
            number10.color = "black";
            number10.half = "first";
            number10.column = "first";
            number10.dozen = "first";

            number11.number = 11;
            number11.oddity = "odd";
            number11.color = "black";
            number11.half = "first";
            number11.column = "second";
            number11.dozen = "first";

            number12.number = 12;
            number12.oddity = "even";
            number12.color = "red";
            number12.half = "first";
            number12.column = "third";
            number12.dozen = "first";

            number13.number = 13;
            number13.oddity = "odd";
            number13.color = "black";
            number13.half = "first";
            number13.column = "first";
            number13.dozen = "second";

            number14.number = 14;
            number14.oddity = "even";
            number14.color = "red";
            number14.half = "first";
            number14.column = "second";
            number14.dozen = "second";

            number15.number = 15;
            number15.oddity = "odd";
            number15.color = "black";
            number15.half = "first";
            number15.column = "third";
            number15.dozen = "second";

            number16.number = 16;
            number16.oddity = "even";
            number16.color = "red";
            number16.half = "first";
            number16.column = "first";
            number16.dozen = "second";

            number17.number = 17;
            number17.oddity = "odd";
            number17.color = "black";
            number17.half = "first";
            number17.column = "second";
            number17.dozen = "second";

            number18.number = 18;
            number18.oddity = "even";
            number18.color = "red";
            number18.half = "first";
            number18.column = "third";
            number18.dozen = "second";

            number19.number = 19;
            number19.oddity = "odd";
            number19.color = "red";
            number19.half = "first";
            number19.column = "first";
            number19.dozen = "second";

            number20.number = 20;
            number20.oddity = "even";
            number20.color = "black";
            number20.half = "second";
            number20.column = "second";
            number20.dozen = "second";

            number21.number = 21;
            number21.oddity = "odd";
            number21.color = "red";
            number21.half = "second";
            number21.column = "third";
            number21.dozen = "second";

            number22.number = 22;
            number22.oddity = "even";
            number22.color = "black";
            number22.half = "second";
            number22.column = "first";
            number22.dozen = "second";

            number23.number = 23;
            number23.oddity = "odd";
            number23.color = "red";
            number23.half = "second";
            number23.column = "second";
            number23.dozen = "second";

            number24.number = 24;
            number24.oddity = "even";
            number24.color = "black";
            number24.half = "second";
            number24.column = "third";
            number24.dozen = "second";

            number25.number = 25;
            number25.oddity = "odd";
            number25.color = "red";
            number25.half = "second";
            number25.column = "first";
            number25.dozen = "third";

            number26.number = 26;
            number26.oddity = "even";
            number26.color = "black";
            number26.half = "second";
            number26.column = "second";
            number26.dozen = "third";

            number27.number = 27;
            number27.oddity = "odd";
            number27.color = "red";
            number27.half = "second";
            number27.column = "third";
            number27.dozen = "third";

            number28.number = 28;
            number28.oddity = "even";
            number28.color = "black";
            number28.half = "second";
            number28.column = "first";
            number28.dozen = "third";

            number29.number = 29;
            number29.oddity = "odd";
            number29.color = "black";
            number29.half = "second";
            number29.column = "second";
            number29.dozen = "third";

            number30.number = 30;
            number30.oddity = "even";
            number30.color = "red";
            number30.half = "second";
            number30.column = "third";
            number30.dozen = "third";

            number31.number = 31;
            number31.oddity = "odd";
            number31.color = "black";
            number31.half = "second";
            number31.column = "first";
            number31.dozen = "third";

            number32.number = 32;
            number32.oddity = "even";
            number32.color = "red";
            number32.half = "second";
            number32.column = "second";
            number32.dozen = "third";

            number33.number = 33;
            number33.oddity = "odd";
            number33.color = "black";
            number33.half = "second";
            number33.column = "third";
            number33.dozen = "third";

            number34.number = 34;
            number34.oddity = "even";
            number34.color = "red";
            number34.half = "second";
            number34.column = "first";
            number34.dozen = "third";

            number35.number = 35;
            number35.oddity = "odd";
            number35.color = "black";
            number35.half = "second";
            number35.column = "second";
            number35.dozen = "third";

            number36.number = 36;
            number36.oddity = "even";
            number36.color = "red";
            number36.half = "second";
            number36.column = "third";
            number36.dozen = "third";
            #endregion RESULTSPROPERTIES

            //
            // add results to the list
            //
            #region ADDRESULTSTOLIST
            results.Add(number1);
            results.Add(number2);
            results.Add(number3);
            results.Add(number4);
            results.Add(number5);
            results.Add(number6);
            results.Add(number7);
            results.Add(number8);
            results.Add(number9);
            results.Add(number10);
            results.Add(number11);
            results.Add(number12);
            results.Add(number13);
            results.Add(number14);
            results.Add(number15);
            results.Add(number16);
            results.Add(number17);
            results.Add(number18);
            results.Add(number19);
            results.Add(number20);
            results.Add(number21);
            results.Add(number22);
            results.Add(number23);
            results.Add(number24);
            results.Add(number25);
            results.Add(number26);
            results.Add(number27);
            results.Add(number28);
            results.Add(number29);
            results.Add(number30);
            results.Add(number31);
            results.Add(number32);
            results.Add(number33);
            results.Add(number34);
            results.Add(number35);
            results.Add(number36);
            #endregion ADDRESULTSTOLIST
        }

        private static void DisplayMainMenu()
        {
            string menuChoice;
            bool quitApplication = false;
            int cash = 0;
            int cashToAdd;
            int spinResult;

            do
            {

                DisplayScreenHeader("Main Menu");

                //
                // get the user's menu choice
                //
                Console.WriteLine("a) View Rules");
                Console.WriteLine("b) Add Money to Pool");
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
                        PlaceBet(cash);
                        break;

                    case "d":

                        break;

                    case "e":
                        spinResult = SpinTheWheel();
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
        public static int DollarsToChips(int cash)
        {
            int total;
            int cashToAdd;

            DisplayScreenHeader("Add more money to the table.");

            Console.Write("How much money would you like to add? (whole dollars only) ");
            cashToAdd = int.Parse(Console.ReadLine());       /// todo - Check for int, if not give feedback and loop
                                                             /// todo - Check for positive number, if not give feedback and loop
            total = cash + cashToAdd;

            Console.WriteLine($"{cashToAdd:C} has been added to your pool of betting money.");

            Console.WriteLine($"Your new total is {total:C}");

            DisplayContinuePrompt();

            return total;
        }

        //
        // menu system to place bets
        //
        public static void PlaceBet(int cash)
        {
            string menuChoice;
            bool quitApplication = false;

            do
            {

                DisplayScreenHeader("Place your bet");

                //
                // get the user's menu choice
                //
                Console.WriteLine("a) Bet on a specific number");
                Console.WriteLine("b) Bet on oddity - WIP");
                Console.WriteLine("c) Bet on color - WIP");
                Console.WriteLine("d) Bet on half - WIP");
                Console.WriteLine("e) Bet on column - WIP");
                Console.WriteLine("f) Bet on dozen - WIP");
                Console.WriteLine("q) Quit");
                Console.Write("Enter Choice: ");
                menuChoice = Console.ReadKey().Key.ToString().ToLower().Trim();


                //
                // process user's choice
                //
                switch (menuChoice)
                {
                    case "a":
                        BetOnNumber(cash);
                        break;

                    case "b":
                        BetOnOddity(cash);
                        break;
                    case "c":
                        BetOnColor(cash);
                        break;

                    case "d":
                        BetOnHalf(cash);
                        break;

                    case "e":
                        BetOnColumn(cash);
                        break;

                    case "f":
                        BetOnDozen(cash);
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

        public static int SpinTheWheel()
        {
            int ball;

            DisplayScreenHeader("The wheel has been spun");

            Random rnd = new Random();
            ball = rnd.Next(1, 37);
            Console.WriteLine($"The ball landed on {ball}");

            DisplayContinuePrompt();

            return ball;
        }

        #endregion

        #region PLACEBET() METHODS

        public static int BetOnNumber(int cash)
        {
            int bet;
            int betAmount;
            
            DisplayScreenHeader("Bet on a number");

            Console.WriteLine();
            Console.Write("How much would you like to bet?: ");
            int.TryParse(Console.ReadLine(), out betAmount);

            Console.WriteLine();
            Console.Write("Place bet (1-36): ");
            int.TryParse(Console.ReadLine(), out bet);

            Console.WriteLine();
            Console.WriteLine($"You are betting {betAmount:C} on number {bet}.");

            cash = cash - betAmount;

            DisplayContinuePrompt();
            return bet;
        }

         public static string BetOnOddity(int cash)
         {
            string oddity;
            int betAmount;   

            DisplayScreenHeader("Bet on Odd or Even");

            Console.WriteLine();
            Console.Write("How much would you like to bet?: ");
            int.TryParse(Console.ReadLine(), out betAmount);

            Console.WriteLine();
            Console.Write("Even or odd?: ");
            oddity = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"You are betting {betAmount:C} on {oddity}.");

            cash = cash - betAmount;

            DisplayContinuePrompt();

            return oddity;
         }

         public static string BetOnColor(int cash)
         {
            string color;
            int betAmount;

            DisplayScreenHeader("Bet on Red or Black");

            Console.WriteLine();
            Console.Write("How much would you like to bet?: ");
            int.TryParse(Console.ReadLine(), out betAmount);

            Console.WriteLine();
            Console.Write("Even or odd?: ");
            color = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"You are betting {betAmount:C} on {color}.");

            cash = cash - betAmount;

            DisplayContinuePrompt();

            return color;
         }

         public static string BetOnHalf(int cash)
         {
            string half;
            int betAmount;

            DisplayScreenHeader("Bet on first half or second half");

            Console.WriteLine();
            Console.Write("How much would you like to bet?: ");
            int.TryParse(Console.ReadLine(), out betAmount);

            Console.WriteLine();
            Console.Write("Which half? (first or second): ");
            half = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"You are betting {betAmount:C} on the {half} half.");

            cash = cash - betAmount;

            DisplayContinuePrompt();

            return half;
         }

         public static string BetOnColumn(int cash)
         {
            string column;
            int betAmount;

            DisplayScreenHeader("Bet on a column");

            Console.WriteLine();
            Console.Write("How much would you like to bet?: ");
            int.TryParse(Console.ReadLine(), out betAmount);

            Console.WriteLine();
            Console.Write("First, second, or third?: ");
            column = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"You are betting {betAmount:C} on the {column} column.");

            cash = cash - betAmount;

            DisplayContinuePrompt();

            return column;
         }

         public static string BetOnDozen(int cash)
         {
            string dozen;
            int betAmount;

            DisplayScreenHeader("Bet on a dozen");

            Console.WriteLine();
            Console.Write("How much would you like to bet?: ");
            int.TryParse(Console.ReadLine(), out betAmount);

            Console.WriteLine();
            Console.Write("first, second, or third?: ");
            dozen = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"You are betting {betAmount:C} on the {dozen} dozen.");

            cash = cash - betAmount;

            DisplayContinuePrompt();

            return dozen;
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
