namespace Example3_FightingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Show.HorizontalDivider();

            GoodGuy harry = new GoodGuy("Harry Potter", 999);
            GoodGuy hermione = new GoodGuy("Hermione Granger", 200);
            GoodGuy ron = new GoodGuy("Ron Weasley", 100);

            BadGuy voldemort = new BadGuy("Tom Riddle", 800);
            BadGuy bellatrix = new BadGuy("Bellatrix Lestrange", 600);
            BadGuy draco = new BadGuy("Draco Malfoy", 400);

            Show.HorizontalDivider();

            voldemort.Steal(harry, 200);
            voldemort.Steal(draco, 200);
            bellatrix.Steal(draco, 200);

            harry.Capture(bellatrix);
            harry.Give(hermione, 400);
            harry.Give(ron, 400);

            Show.HorizontalDivider();
            System.Console.ReadKey();
        }
    }
}