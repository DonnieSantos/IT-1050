namespace Example1_MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Person donnie = new Person();
            donnie.FirstName = "Donnie";
            donnie.LastName = "Santos";
            donnie.Age = 37;

            Person michael = new Person();
            michael.FirstName = "Michael";
            michael.LastName = "Santos";
            michael.Age = 29;

            int sum1 = donnie.AddTwoIntegers(7, 8);
            int sum2 = donnie.AddTwoIntegers(1, 9);
            int sum3 = donnie.AddTwoIntegers(2, 13);

            donnie.Speak("I am the smartest person in the world!");
            michael.Speak("That is definitely true.");

            System.Console.ReadKey();
        }
    }
}