namespace ConsoleApplication1
{
    public class MyConsole
    {
        public static string ReadString(string prompt)
        {
            System.Console.Write(" " + prompt.PadRight(33) + " : ");
            return System.Console.ReadLine();
        }

        public static int ReadInteger(string prompt)
        {
            return int.Parse(ReadString(prompt));
        }

        public static bool ReadBool(string prompt)
        {
            string input = System.Console.ReadLine().ToLower();
            return input.StartsWith("y") || input.StartsWith("t");
        }
    }
}