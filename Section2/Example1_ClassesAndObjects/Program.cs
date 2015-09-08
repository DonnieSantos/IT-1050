namespace Example1_ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person somePerson;                      // Variable Declaration
            somePerson = new Person();              // Value Assignment (Object Instantiation)
            somePerson.Name = "John Doe";           // Value Assignment (Object Member Variable)
            somePerson.Age = 21;                    // Value Assignment (Object Member Variable)

            Person anotherPerson;                   // Variable Declaration
            anotherPerson = new Person();           // Value Assignment (Object Instantiation)
            anotherPerson.Name = "Jane Doe";        // Value Assignment (Object Member Variable)
            anotherPerson.Age = 19;                 // Value Assignment (Object Member Variable)

            Person oldestPerson = somePerson;       // Value Assignment (Object Reference)

            // +===============================================================================+
            // | Managed Languages (like C#) have a "Garbage Collector", or "GC".              |
            // | The GC constantly searches for completely dereferenced objects to destroy.    |
            // +===============================================================================+

            anotherPerson = null; 
            // This will reduce the number of references to the second person object.
            // Since that is the only reference, it will be completely destroyed.

            somePerson = null;
            // This will reduce the number of references to the first person object.
            // Since it still has another reference, it will not be destroyed.

            oldestPerson = null;
            // This will reduce the number of references to the first person object.
            // Now there are no more references to it, so it will be destroyed.
        }
    }
}