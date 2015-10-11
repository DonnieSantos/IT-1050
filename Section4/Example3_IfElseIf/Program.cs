namespace Example3_IfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter a String : ");
            string input = System.Console.ReadLine();
            System.Console.WriteLine();
            
            if (input == input.ToLower())
            {
                System.Console.WriteLine("The output contains all lower-case letters.");
            }
            else if (input == input.ToUpper())
            {
                System.Console.WriteLine("The output contains all upper-case letters.");
            }
            else
            {
                System.Console.WriteLine("The output contains both upper-case and lower-case letters.");
            }

            bool containsA = input.ToUpper().Contains("A");
            bool containsZ = input.ToUpper().Contains("Z");

            if (containsA && containsZ)
            {
                System.Console.WriteLine("The output contains both A and Z.");
            }
            else if (containsA && !containsZ)
            {
                System.Console.WriteLine("The output contains A, but does not contain Z.");
            }
            else if (!containsA && containsZ)
            {
                System.Console.WriteLine("The output contains Z, but does not contain A.");
            }
            else
            {
                System.Console.WriteLine("The output does not contain A or Z.");
            }

            System.Console.WriteLine();
            System.Console.Write("Press any key to continue... ");
            System.Console.ReadKey();
        }
    }
}