namespace Example4_BasicInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("What is your name? ");            // Console Output

            string userName;                                        // Variable Declaration

            userName = System.Console.ReadLine();                   // Console Input & Value Assignment (string)

            System.Console.Write("How old are you? ");              // Console Output

            int userAge;                                            // Variable Declaration

            userAge = int.Parse(System.Console.ReadLine());         // Console Input & Value Assignment (int)

            System.Console.Write("Your name is : ");                // Console Output
            System.Console.WriteLine(userName);                     // Console Output (with newline)
            System.Console.Write("Your age is  : ");                // Console Output
            System.Console.WriteLine(userAge);                      // Console Output (with newline)

            System.Console.Write("Press any key to continue... ");  // Console Output
            System.Console.ReadKey();                               // Pause Program Until Key Is Pressed.
        }
    }
}