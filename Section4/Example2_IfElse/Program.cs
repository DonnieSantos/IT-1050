namespace Example2_IfElse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter a Number : ");
            string inputString = System.Console.ReadLine();
            int inputInteger = int.Parse(inputString);

            if (inputInteger >= 0)
            {
                System.Console.WriteLine("The number is positive.");
            }
            else
            {
                System.Console.WriteLine("The number is negative");
            }

            if (inputInteger >= -9 && inputInteger <= 9)
            {
                System.Console.WriteLine("The number is single digit.");
            }
            else
            {
                System.Console.WriteLine("The number has multiple digits.");
            }

            System.Console.ReadKey();
        }
    }
}