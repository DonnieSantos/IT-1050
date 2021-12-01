namespace Part9_Constructors
{
    class Person
    {
        private int age;
        private string name;

        // Manually putting back the default constructor.
        // Because if you define any constructors, you lose the default one you get automatically.
        // So in this case we just have to put it back in, very easily.

        public Person() { }

        // This constructor allows you to create a person and specify the age.

        public Person(int age)
        {
            this.age = age;
        }

        // This constructor allows you to create a person and specify the name and the age.
        // Now we have three constructors. Having multiple constructors (or any methods)
        // with the same name but different signatures (parameter list types) is called "overloading"
        // We say here now, for the entire class, we have three overloaded constructors.
        //     1.) Person()
        //     2.) Person(int)
        //     3.) Person(name, age)

        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        public void DisplayNameAndAge()
        {
            System.Console.WriteLine("My name is " + this.name + " and I am " + this.age + " years old.");
        }
    }
}