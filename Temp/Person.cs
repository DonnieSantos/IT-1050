namespace ConsoleApplication2
{
    class Person
    {
        public string Name;
        public int Age;
        public Person Spouse;
        public bool IsMarried()
        {
            return Spouse != null;
        }
    }
}