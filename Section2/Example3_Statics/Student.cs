namespace Example3_Statics
{
    class Student
    {
        // +======================================================================================+
        // | These are standard member variables. Every Student object has a Name and Grade.      |
        // +======================================================================================+

        public string Name;
        public string Grade;

        // +======================================================================================+
        // | This is a static variable. The Student instance objects do not have a Count.         |
        // | This variable only exists in a single place, that that is on the class.              |
        // | To access it, you have to use the syntax "Student.Count".                            |
        // +======================================================================================+

        public static int Count;

        // +======================================================================================+
        // | Static methods also are not avaialble to instance objects, only to the class.        |
        // | You would only use a static method if it does not depend on a particular object.     |
        // | Static methods and variables are global, you can access them anywhere.               |
        // | The way to invoke this method would be with the syntax Student."HelloWorld()".       |
        // +======================================================================================+

        public static void HelloWorld()
        {
            System.Console.WriteLine("Hello World");
        }
    }
}