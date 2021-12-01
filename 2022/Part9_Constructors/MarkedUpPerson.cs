namespace Part9_Constructors
{
    /// <summary>
    /// This class is intended to be exactly the same as Person,
    /// but it is using Visual Studio's intellisense markup tools.
    /// Just look at the way it gives you intellisense in the main program.
    /// </summary>
    class MarkedUpPerson
    {
        /// <summary>
        /// The Person's age.
        /// </summary>
        private int age;

        /// <summary>
        /// The Person's name.
        /// </summary>
        private string name;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public MarkedUpPerson() { }

        /// <summary>
        /// A Constructor that takes the Person's age as a parameter.
        /// </summary>
        /// <param name="age">The Person's age.</param>
        public MarkedUpPerson(int age)
        {
            this.age = age;
        }

        /// <summary>
        /// A Constructor that takes the Person's name and age as parameters.
        /// </summary>
        /// <param name="name">The Person's name.</param>
        /// <param name="age">The Person's age.</param>
        public MarkedUpPerson(string name, int age)
        {
            this.age = age;
            this.name = name;
        }

        /// <summary>
        /// Writes to the Console the name and age of the person, in a formatted sentence.
        /// </summary>
        public void DisplayNameAndAge()
        {
            System.Console.WriteLine("My name is " + this.name + " and I am " + this.age + " years old.");
        }
    }
}
