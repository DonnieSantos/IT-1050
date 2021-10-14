using IO = System.Console;

// https://dotnetfiddle.net/eVdFw0

namespace Part6_ClassesAndObjects
{
    public static class Runner
    {
        public static void Start()
        {
            Student s1 = new Student();
            s1.sNumber = "S00812345";
            s1.firstName = "Jane";
            s1.lastName = "Doe";
            s1.courses = new int[3] { 81760, 81761, 81762 };

            Student s2 = new Student();
            s2.sNumber = "S00867890";
            s2.firstName = "John";
            s2.lastName = "Doe";
            s2.courses = new int[2] { 81760, 81761 };

            IO.Write(s1.firstName + " is taking " + s1.courses.Length + " courses: ");
            IO.Write("\n" + s2.firstName + " is taking " + s2.courses.Length + " courses: ");

            Student mostBusy = s1;

            if (mostBusy == s1) { IO.WriteLine("\n\n1.) 's1' and 'mostBusy' are pointing at the same object. (Jane)"); }
            if (mostBusy != s2) { IO.WriteLine("    's2' and 'mostBusy' are not pointing at the same object. (s2 is pointing at John)"); }
            IO.WriteLine("    This means we have three variables ('s1', 's2', 'mostBusy') but only two objects (Jane and John).\n");

            s1 = null;

            IO.WriteLine("2.) 's1' is no longer pointing to Jane, but 'mostBusy' is still pointing at her.\n");

            mostBusy = null;

            IO.WriteLine("3.) Now Jane has been completely de-referenced, so the object is destroyed.");
            IO.WriteLine("    's1' and 'mostBusy' are now both null, while 's2' is still pointing at John.");
        }
    }
}