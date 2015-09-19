namespace Example1_MethodParameters
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

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
    }
}