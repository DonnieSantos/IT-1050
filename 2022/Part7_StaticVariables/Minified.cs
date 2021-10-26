using IO = System.Console;

// https://dotnetfiddle.net/QzCayf

namespace Part7_StaticVariables
{
    class Minified
    {
        public static void Runner()
        {
            Human p1 = new Human();
            Human p2 = new Human();
            p1.firstName = "Donnie";  p1.lastName = "Wahlberg";  p1.isMarried = true;   p1.age = 52;
            p2.firstName = "Donnie";  p2.lastName = "Santos";    p2.isMarried = false;  p2.age = 43;
            Human.count = 2;

            IO.WriteLine("There are a total of " + Human.count + " humans.");
            IO.WriteLine(p1.firstName + " " + p1.lastName + " is " + p1.age + "-years-old and " + (p1.isMarried ? "is married." : "is NOT married."));
            IO.WriteLine(p2.firstName + " " + p2.lastName + " is " + p2.age + "-years-old and " + (p2.isMarried ? "is married." : "is NOT married."));
            IO.WriteLine(p1.firstName + " " + p1.lastName + " " + (Human.warmBlooded ? "is" : "is not") + " a warm-blooded " + Human.species + ".");
            IO.WriteLine(p2.firstName + " " + p2.lastName + " " + (Human.warmBlooded ? "is" : "is not") + " a warm-blooded " + Human.species + ".");
        }
    }
}
