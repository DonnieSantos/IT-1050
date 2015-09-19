namespace Example2_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person donnie = new Person("Donnie", "Santos", 37);
            Person michael = new Person("Michael", "Santos", 29);

            Person alana = new Person();
            alana.FirstName = "Alana";
            alana.LastName = "Santos";
            alana.Age = 43;

            int sum1 = donnie.AddTwoIntegers(7, 8);
            int sum2 = donnie.AddTwoIntegers(1, 9);
            int sum3 = donnie.AddTwoIntegers(2, 13);

            donnie.Speak("I am the smartest person in the world!");
            michael.Speak("That is definitely true.");
            alana.Speak("Word.");

            System.Console.ReadKey();
        }
    }
}