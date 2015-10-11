namespace Example1_If
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter a Number : ");
            string inputString = System.Console.ReadLine();
            int inputInteger = int.Parse(inputString);

            if (inputInteger > 10)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Inside first 'if' block.");
                System.Console.WriteLine("The number is larger than 10.");
            }

            if (inputInteger > 100)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Inside second 'if' block.");
                System.Console.WriteLine("The number is larger than 100.");
            }

            if (inputInteger > 1000)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Inside third 'if' block.");
                System.Console.WriteLine("The number is larger than 1000.");
            }

            if (inputInteger >= 50 && inputInteger <= 60)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Inside fourth 'if' block.");
                System.Console.WriteLine("The number is between 50 and 60.");
            }

            System.Console.WriteLine();
            System.Console.Write("Press any key to continue... ");
            System.Console.ReadKey();
        }
    }
}