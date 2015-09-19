namespace Example2_Constructors
{
    class Person
    {
        ////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////

        public string FirstName;
        public string LastName;
        public int Age;

        ////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////

        // +-----------------------------------------+
        // | Definition of Constructor:              |
        // | Method with the same name as the class! |
        // | No return type!                         |
        // +-----------------------------------------+

        // Constructor Version 1
        public Person()
        {
        }

        // Constructor Version 2
        public Person(string theirFirstName, string theirLastName, int theirAge)
        {
            this.FirstName = theirFirstName;
            this.LastName = theirLastName;
            this.Age = theirAge;
        }

        ////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////

        public int AddTwoIntegers(int theFirstNumber, int theSecondNumber)
        {
            return theFirstNumber + theSecondNumber;
        }

        public void Speak(string whatToSay)
        {
            string output = this.FirstName;
            output += " ";
            output += this.LastName;
            output += " says, '";
            output += whatToSay;
            output += "'";

            System.Console.WriteLine(output);
        }

        ////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////
    }
}