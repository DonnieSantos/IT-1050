namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person();

            System.Console.WriteLine("Are you married? (y/n) ");

            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                p1.Spouse = new Person();
                p1.Spouse.Name = "";
            }
        }
    }
}