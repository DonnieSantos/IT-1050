using IO = System.Console;

namespace Part6_ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declare, Instantiate, and Hydrate objects.

            Student s1;                     // Declare variable named 's1' of type 'Student'.
            s1 = new Student();             // Instantiate a new Student object and assign its address to 's1'.
            s1.sNumber = "S00812345";       // Assign a literal string value to the variable 'sNumber' within the object being referenced by 's1'.
            s1.firstName = "Jane";          // Assign a literal string value to the variable 'firstName' within the object being referenced by 's1'.
            s1.lastName = "Doe";            // Assign a literal string value to the variable 'lastName' within the object being referenced by 's1'.
            s1.courses = new int[3];        // Allocate enough memory for three integers for the array 'courses' within the object being referenced by 's1'.
            s1.courses[0] = 81760;          // Assign the integer value of '81760' to the first position in the 'courses' array.
            s1.courses[1] = 81761;          // Assign the integer value of '81761' to the second position in the 'courses' array.
            s1.courses[2] = 81762;          // Assign the integer value of '81762' to the third position in the 'courses' array.

            Student s2;                     // Declare variable named 's2' of type 'Student'.
            s2 = new Student();             // Instantiate a new Student object and assign its address to 's2'.
            s2.sNumber = "S00867890";       // Assign a literal string value to the variable 'sNumber' within the object being referenced by 's2'.
            s2.firstName = "John";          // Assign a literal string value to the variable 'firstName' within the object being referenced by 's2'.
            s2.lastName = "Doe";            // Assign a literal string value to the variable 'lastName' within the object being referenced by 's2'.
            s2.courses = new int[2];        // Allocate enough memory for two integers for the array 'courses' within the object being referenced by 's2'.
            s2.courses[0] = 81760;          // Assign the integer value of '81760' to the first position in the 'courses' array.
            s2.courses[1] = 81761;          // Assign the integer value of '81761' to the second position in the 'courses' array.

            #endregion

            #region Some Simple Initial Output

            IO.Write(s1.firstName + " is taking " + s1.courses.Length + " courses: ");          // Print out some of the values in 's1'.
            foreach (int CRN in s1.courses) { IO.Write("<" + CRN + "> "); }                     // Print out some of the values in 's1'.
            IO.Write("\n" + s2.firstName + " is taking " + s2.courses.Length + " courses: ");   // Print out some of the values in 's2'.
            foreach (int CRN in s2.courses) { IO.Write("<" + CRN + "> "); }                     // Print out some of the values in 's2'.

            #endregion

            #region Part 1

            Student mostBusy;       // Declare a third Student variable named 'mostBusy'.
            mostBusy = s1;          // Assign the reference held by 's1' to the variable 'mostBusy'.

            if (mostBusy == s1) { IO.WriteLine("\n\n1.) 's1' and 'mostBusy' are pointing at the same object. (Jane)"); }
            if (mostBusy != s2) { IO.WriteLine("    's2' and 'mostBusy' are not pointing at the same object. (s2 is pointing at John)"); }
            IO.WriteLine("    This means we have three variables ('s1', 's2', 'mostBusy') but only two objects (Jane and John).\n");

            #endregion

            #region Part 2

            s1 = null;  // Remove the reference from 's1' which was previously pointing at Jane.

            if (s1 == null && mostBusy.firstName == "Jane")
            {
                IO.WriteLine("2.) 's1' is no longer pointing to Jane, but 'mostBusy' is still pointing at her.\n");
            }

            #endregion

            #region Part 3

            mostBusy = null;  // Remove the second and final reference to Jane--now that object will be destroyed.

            if (s1 == null && mostBusy == null && s2.firstName == "John")
            {
                IO.WriteLine("3.) Now Jane has been completely de-referenced, so the object is destroyed.");
                IO.WriteLine("    's1' and 'mostBusy' are now both null, while 's2' is still pointing at John.");
                IO.ReadKey();
            }

            #endregion
        }
    }
}
