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
            List<Result> results = new List<Result>();

            //
            // instantiate results
            //
            #region NEWRESULTS
            Result number1 = newResult();
            Result number2 = newResult();
            Result number3 = newResult();
            Result number4 = newResult();
            Result number5 = newResult();
            Result number6 = newResult();
            Result number7 = newResult();
            Result number8 = newResult();
            Result number9 = newResult();
            Result number10 = newResult();
            Result number11 = newResult();
            Result number12 = newResult();
            Result number13 = newResult();
            Result number14 = newResult();
            Result number15 = newResult();
            Result number16 = newResult();
            Result number17 = newResult();
            Result number18 = newResult();
            Result number19 = newResult();
            Result number20 = newResult();
            Result number21 = newResult();
            Result number22 = newResult();
            Result number23 = newResult();
            Result number24 = newResult();
            Result number25 = newResult();
            Result number26 = newResult();
            Result number27 = newResult();
            Result number28 = newResult();
            Result number29 = newResult();
            Result number30 = newResult();
            Result number31 = newResult();
            Result number32 = newResult();
            Result number33 = newResult();
            Result number34 = newResult();
            Result number35 = newResult();
            Result number36 = newResult();
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
