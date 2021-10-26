using IO = System.Console;

// https://dotnetfiddle.net/dS2rwV

namespace Part7_StaticVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Human p1 = new Human();     // Create new instance object of type Human.
            p1.firstName = "Donnie";    // Set Member Variable Values.
            p1.lastName = "Wahlberg";   // Set Member Variable Values.
            p1.isMarried = true;        // Set Member Variable Values.
            p1.age = 52;                // Set Member Variable Values.

            Human p2 = new Human();     // Create new instance object of type Human.
            p2.firstName = "Donnie";    // Set Member Variable Values.
            p2.lastName = "Santos";     // Set Member Variable Values.
            p2.isMarried = false;       // Set Member Variable Values.
            p2.age = 43;                // Set Member Variable Values.

            Human.count = 2;            // Set Static Variable Value.

            #region Display Stylized Output

            string p1MaritalStatus = p1.isMarried ? "is married." : "is NOT married.";
            string p2MaritalStatus = p2.isMarried ? "is married." : "is NOT married.";

            IO.WriteLine("There are a total of " + Human.count + " humans.");
            IO.WriteLine(p1.firstName + " " + p1.lastName + " is " + p1.age + "-years-old and " + p1MaritalStatus);
            IO.WriteLine(p2.firstName + " " + p2.lastName + " is " + p2.age + "-years-old and " + p2MaritalStatus);
            IO.WriteLine(p1.firstName + " " + p1.lastName + " " + (Human.warmBlooded ? "is" : "is not") + " a warm-blooded " + Human.species + ".");
            IO.WriteLine(p2.firstName + " " + p2.lastName + " " + (Human.warmBlooded ? "is" : "is not") + " a warm-blooded " + Human.species + ".");

            #endregion
        }
    }
}
