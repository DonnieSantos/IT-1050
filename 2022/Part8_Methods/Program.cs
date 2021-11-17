namespace Part8_Methods
{
    // https://dotnetfiddle.net/cnYgL7 (min)
    // https://dotnetfiddle.net/x5NGHk (doc)
    // https://dotnetfiddle.net/gLt1QD (adv)

    class Program
    {
        static void Main(string[] args)
        {
            Person donnie = new Person();
            donnie.setNameAndAge("Donnie", 43);
            Person.NUM_PEOPLE++;
            Person.SUM_OF_ALL_AGES += donnie.getAge();
            System.Console.WriteLine(donnie.getAge());

            int blah = donnie.getAge();

            Person michael = new Person();
            michael.setNameAndAge("Michael", 35);
            Person.NUM_PEOPLE++;
            Person.SUM_OF_ALL_AGES += michael.getAge();

            donnie.printNameAndAge();
            michael.printNameAndAge();

            Person.printAverageAge();

            System.Console.ReadKey();
        }
    }
}
