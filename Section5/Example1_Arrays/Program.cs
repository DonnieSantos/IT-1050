using Example4_ClassLibraries;

namespace Example1_Arrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////

            int[] arrayOfIntegers;                                  // Array Variable Declaration.
            arrayOfIntegers = new int[3];                           // Array Memory Allocation.

            arrayOfIntegers[0] = 15;                                // Value Assignment.
            arrayOfIntegers[1] = 27;                                // Value Assignment.
            arrayOfIntegers[2] = 39;                                // Value Assignment.

            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////

            string[] arrayOfStrings;                                // Array Variable Declaration.
            arrayOfStrings = new string[3];                         // Array Memory Allocation.

            arrayOfStrings[0] = "One";                              // Value Assignment.
            arrayOfStrings[1] = "Two";                              // Value Assignment.
            arrayOfStrings[2] = "Three";                            // Value Assignment.

            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////

            Widget[] arrayOfWidgets;                                // Array Variable Declaration.
            arrayOfWidgets = new Widget[3];                         // Array Memory Allocation.

            arrayOfWidgets[0] = new Widget();                       // Object Instantiation.
            arrayOfWidgets[0].SetID(75);                            // Object Method Invocation.
            arrayOfWidgets[0].SetDescription("Item Number 75.");    // Object Method Invocation.

            arrayOfWidgets[1] = new Widget();                       // Object Instantiation.
            arrayOfWidgets[1].SetID(82);                            // Object Method Invocation.
            arrayOfWidgets[1].SetDescription("Item Number 82.");    // Object Method Invocation.

            arrayOfWidgets[2] = new Widget();                       // Object Instantiation.
            arrayOfWidgets[2].SetID(96);                            // Object Method Invocation.
            arrayOfWidgets[2].SetDescription("Item Number 96.");    // Object Method Invocation.

            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////

            System.Console.WriteLine(arrayOfIntegers.Length);       // Print the array's length.
            System.Console.WriteLine(arrayOfStrings.Length);        // Print the array's length.
            System.Console.WriteLine(arrayOfWidgets.Length);        // Print the array's length.

            System.Console.WriteLine(arrayOfIntegers[0]);           // Print the integer. (OK)
            System.Console.WriteLine(arrayOfStrings[0]);            // Print the string. (OK)
            System.Console.WriteLine(arrayOfWidgets[0]);            // Pring the object? (Not OK!)
            System.Console.WriteLine(arrayOfWidgets[0].GetID());    // Print the object's ID. (OK)

            ///////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////
        }
    }
}