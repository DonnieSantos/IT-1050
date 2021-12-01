using System;

namespace Part9_Constructors
{
    public static class IO
    {
        public static void Write(string output) { Console.Write(output); }
        public static void WriteLine(string output) { Console.WriteLine(output); }

        public static void Wait()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue... ");
            Console.ReadKey();
        }
    }
}
