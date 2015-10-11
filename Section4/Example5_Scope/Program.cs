using System;

namespace Example5_Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMainMenu();
            ShowInputPrompt();

            string command = Console.ReadLine();

            if (command == "1")
            {
                Console.WriteLine();
                Console.Write(" Enter Inches : ");
                double inches = double.Parse(Console.ReadLine());
                double conversion = inches * 2.54;
                Console.WriteLine();
                Console.WriteLine(" " + inches + " inches is equal to " + conversion + " centimeters.");
            }
            else if (command == "2")
            {
                Console.WriteLine();
                Console.Write(" Enter Centimeters : ");
                double centimeters = double.Parse(Console.ReadLine());
                double conversion = centimeters / 2.54;
                Console.WriteLine();
                Console.WriteLine(" " + centimeters + " centimeters is equal to " + conversion + " inches.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(" Invalid Command.");
            }

            Console.WriteLine();
            Console.WriteLine(" Press any key to continue... ");
            Console.WriteLine();
            Console.Write(" ");
            Console.ReadKey();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        private static void ShowMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine(" +-------------------------------------------+ ");
            Console.WriteLine(" | Please choose from the following options: | ");
            Console.WriteLine(" +-------------------------------------------+ ");
            Console.WriteLine(" | (1) - Convert from inches to centimeters. | ");
            Console.WriteLine(" | (2) - Convert from centimeters to inches. | ");
            Console.WriteLine(" +-------------------------------------------+ ");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        private static void ShowInputPrompt()
        {
            Console.WriteLine();
            Console.Write(" ---> ");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////
    }
}