namespace Example2_ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Donnie";
            person1.MiddleInitial = "J";
            person1.LastName = "Santos";
            person1.Age = 37;

            Person person2 = new Person();
            person2.FirstName = "Michael";
            person2.MiddleInitial = "A";
            person2.LastName = "Santos";
            person2.Age = 29;

            person1.StateYourNameAndAge();
            person2.StateYourNameAndAge();

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}