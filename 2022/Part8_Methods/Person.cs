namespace Part8_Methods
{
    // https://dotnetfiddle.net/cnYgL7

    class Person
    {
        private int age;
        private string name;

        public static int numPeople;
        public static int sumAllAges;
        public const int minVotingAge = 18;

        public int getAge()
        {
            return this.age;
        }

        public int computeYearsUntilCanVote()
        {
            return Person.minVotingAge - this.age;
        }

        public int getAgeIncrementedBy(int x)
        {
            return this.age + x;
        }

        public int getAgeIncrementedBy(int x, int y)
        {
            return this.age + x + y;
        }

        public static double calculateAverageAge()
        {
            return (double)Person.sumAllAges / (double)Person.numPeople;
        }

        public bool canVote()
        {
            return this.age >= Person.minVotingAge;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setNameAndAge(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void printNameAndAge()
        {
            System.Console.WriteLine("This Person's name is: " + this.name + ".");
            System.Console.WriteLine("This Person's age is: " + this.age + ".");
        }

        public static void printAverageAge()
        {
            System.Console.WriteLine("There are " + Person.numPeople + " with an average age of: " + Person.calculateAverageAge() + ".");
        }
    }
}
