namespace Part8_Methods
{
    // https://dotnetfiddle.net/cnYgL7
    // https://dotnetfiddle.net/x5NGHk

    class Program
    {
        static void Main(string[] args)
        {
            Person donnie = new Person();
            donnie.setNameAndAge("Donnie", 43);
            Person.numPeople++;
            Person.sumAllAges += donnie.getAge();

            Person michael = new Person();
            michael.setNameAndAge("Michael", 35);
            Person.numPeople++;
            Person.sumAllAges += michael.getAge();

            donnie.printNameAndAge();
            michael.printNameAndAge();

            Person.printAverageAge();

            System.Console.ReadKey();
        }
    }
}
