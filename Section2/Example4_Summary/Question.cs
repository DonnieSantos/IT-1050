namespace Example4_Summary
{
    class Question
    {
        public static string AskForString(string prompt)
        {
            System.Console.Write(prompt.PadRight(33) + " : ");
            return System.Console.ReadLine();
        }

        public static int AskForInteger(string prompt)
        {
            return int.Parse(AskForString(prompt));
        }

        public static bool AskForBool(string prompt)
        {
            string input = System.Console.ReadLine().ToLower();
            return input.StartsWith("y") || input.StartsWith("t");
        }
    }
}