namespace Part8_Methods
{
    // https://dotnetfiddle.net/gLt1QD (adv)

    class Person
    {
        public static int NUM_PEOPLE;
        public static int SUM_OF_ALL_AGES;
        public const int MIN_VOTING_AGE = 18;

        public static double calculateAverageAge()
        {
            return (double)Person.SUM_OF_ALL_AGES / (double)Person.NUM_PEOPLE;
        }
        public static void printAverageAge()
        {
            System.Console.WriteLine("There are " + Person.NUM_PEOPLE + " with an average age of: " + Person.calculateAverageAge() + ".");
        }

        private string name;
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        private int age;
        public int getAge()
        {
            System.Console.WriteLine(this.age + " was just accessed.");
            return this.age;
        }
        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAgeIncrementedBy(int x)
        {
            return this.age + x;
        }
        public int computeYearsUntilCanVote()
        {
            return Person.MIN_VOTING_AGE - this.age;
        }
        public int getAgeIncrementedBy(int x, int y)
        {
            return this.age + x + y;
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
        public bool canVote()
        {
            return this.age >= Person.MIN_VOTING_AGE;
        }
    }
}
