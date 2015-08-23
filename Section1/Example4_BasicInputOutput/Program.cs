namespace Example4_BasicInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // +==================================================================================+
            // | To print something to the Console window, we use System.Console.Write.           |
            // | Whatever you put in between the parenthesis will be output to the screen.        |
            // +==================================================================================+

            System.Console.Write("What is your name? ");            // Console Output

            // +==================================================================================+
            // | To read in a value from the user, we use System.Console.ReadLine.                |
            // | Whatever the user types in will be the value assigned to the given variable.     |
            // +==================================================================================+

            string userName;                                        // Variable Declaration

            userName = System.Console.ReadLine();                   // Console Input & Value Assignment (string)

            // +==================================================================================+
            // | It gets a little more tricky if you want to read a value that is not a string.   |
            // | In this case, you have to "parse" the input value into the desired type.         |
            // | For example, the following code will parse the input string into an int.         |
            // +==================================================================================+

            System.Console.Write("How old are you? ");              // Console Output

            int userAge;                                            // Variable Declaration

            userAge = int.Parse(System.Console.ReadLine());         // Console Input & Value Assignment (int)

            // +==================================================================================+
            // | You can write literal values as well as variable values to the screen.           |
            // +==================================================================================+

            System.Console.Write("Your name is : ");                // Console Output
            System.Console.WriteLine(userName);                     // Console Output (with newline)
            System.Console.Write("Your age is  : ");                // Console Output
            System.Console.WriteLine(userAge);                      // Console Output (with newline)

            System.Console.Write("Press any key to continue... ");  // Console Output
            System.Console.ReadKey();                               // Pause Program Until Key Is Pressed.
        }
    }
}