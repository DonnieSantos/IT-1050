namespace Example3_Statics
{
    class Teacher
    {
        // +======================================================================================+
        // | This is a standard member variable. Every Teacher instance object has a Name.        |
        // +======================================================================================+

        public string Name;

        // +======================================================================================+
        // | This is a static variable. The Teacher instance objects do not have a Count.         |
        // | This variable only exists in a single place, that that is on the class.              |
        // | To access it, you have to use the syntax "Teacher.Count".                            |
        // +======================================================================================+

        public static int Count;
    }
}