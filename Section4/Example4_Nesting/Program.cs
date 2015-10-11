namespace Example4_Nesting
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageFromComputer("Hello There.");

            string input = System.Console.ReadLine();

            if (input.Length > 0)
            {
                if (input.ToLower().Contains("hi") || input.ToLower().Contains("hello"))
                {
                    MessageFromComputer("What is your name?");

                    input = System.Console.ReadLine();

                    if (input.Length > 0)
                    {
                        MessageFromComputer("Nice to meet you, " + input + "!");
                    }
                    else
                    {
                        MessageFromComputer("You don't have a name? That's kind of strange.");
                    }
                }
                else
                {
                    MessageFromComputer("Sorry, I didn't understand what you said...");
                }
            }
            else
            {
                MessageFromComputer("You don't want to talk to me? :( ");
            }

            EndProgram();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        private static void MessageFromComputer(string text)
        {
            System.Console.WriteLine();
            System.Console.ForegroundColor = System.ConsoleColor.Green;
            System.Console.WriteLine(" " + text);
            System.Console.WriteLine();
            System.Console.Write(" ");
            System.Console.ResetColor();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        private static void EndProgram()
        {
            System.Console.WriteLine("+------------------------------+ ");
            System.Console.WriteLine(" | Press any key to continue... | ");
            System.Console.WriteLine(" +------------------------------+ ");
            System.Console.Write(" ");
            System.Console.ReadKey();
        }
    }
}