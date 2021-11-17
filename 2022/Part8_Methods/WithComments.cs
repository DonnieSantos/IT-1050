// Read this first.
//
// A method consists of a "Signature" and a "Body".
// The Signature expresses "What" the method does, the Body expresses "How" it does it.
// The "How" is also referred to as "Implementation Details" because the Signature is more important.
// There are infinite ways of implementing the Method Body to accomplish what the Method Signature promises.
//
// We already learned functions, so just think of methods as functions that have context.
// The function doesn't execute in a vacuum, it is invoked by an object or a class.
// Think of it as an action. Actions don't happen alone. Something has to perform the action. (An object or a class)
// You write methods exactly like you wrote functions, you just define them INSIDE A CLASS DEFINITION.
// The class definition defines both variables and methods for its instance objects, and for itself if they are static.
//
// The Signature consists of the method NAME, the RETURN VALUE, and the PARAMETER TYPE LIST.
// The Body is everything in between the Begin Curly Brace "{" and the End Curly Brace "}".
// You cannot define two methods with the same signature.
// If you have two methods with the same name, they must have different parameter type lists, which is called "Overloading".
//
// See these examples for the different kinds of methods a class can define:

namespace Part8_Methods
{
    // https://dotnetfiddle.net/x5NGHk

    class WithComments
    {
        // Member variables.

        private int age;
        private string name;

        // Class variables.

        public static int numPeople;
        public static int sumAllAges;
        public const int minVotingAge = 18;

        // "Getter" pattern, a method with a return value and no parameters.
        // This allows detailed/controlled access to private variables.

        public int getAge()
        {
            return this.age;
        }

        // "Computed Value" pattern, also a method with a return value and no parameters.
        // This computes a value based solely on values that are already stored and known.

        public int computeYearsUntilCanVote()
        {
            return Person.MIN_VOTING_AGE - this.age;
        }

        // "Function", a method with inputs and an output.
        // The inputs are "parameters" and the output is "returned".

        public int getAgeIncrementedBy(int x)
        {
            return this.age + x;
        }

        // Same as above except there are two parameters.
        // Since the method has the same name with a different parameter list, it's an overload.
        // That means it's the same method name, but with a different parameter list and body.

        public int getAgeIncrementedBy(int x, int y)
        {
            return this.age + x + y;
        }

        // A Function that returns a double but has no parameters, and is marked "static".
        // This is exactly the same as a normal "Computed Value" except it has no reference to any instance objects, only the class.

        public static double calculateAverageAge()
        {
            return (double)Person.SUM_OF_ALL_AGES / (double)Person.NUM_PEOPLE;
        }

        // This is a "Computed Value" that is not static itself, but relies on both a member variable value and a static value.

        public bool canVote()
        {
            return this.age >= Person.MIN_VOTING_AGE;
        }

        // A Void Function. (So not really a function at all since a function implies it returns a value...)
        // This is why we use the word "Method" instead of "Function" in C# because it doesn't always return a value.
        // This is a method named "setName" which takes one string parameter and returns void/nothing.
        // Since it returns nothing, the purpose is either to just "do something" or "change the object".
        // Any time a method changes values inside the object, we call that "state mutation". (Change of State)
        // This method is following a "Setter" pattern. The latter version of the "Get/Set" pattern of methods.
        // Instead of asking for the value, we are instructing the object to change its value.

        public void setName(string name)
        {
            this.name = name;
        }

        // This is also a "Setter" it is just setting two things instead of one.

        public void setNameAndAge(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // A void method with no parameters.
        // That means it takes no inputs and has no output.
        // This kind of method usually just means we are trying to save a chunk of code for re-use.
        // There's no other reason to write a parameterless-void method unless you want to re-use code.
        // However, remember that even though it takes no parameters, the behavior still may rely on member variable values.

        public void printNameAndAge()
        {
            System.Console.WriteLine("This Person's name is: " + this.name + ".");
            System.Console.WriteLine("This Person's age is: " + this.age + ".");
        }

        // Same thing except it's static so it has no access to instance objects, only the class:

        public static void printAverageAge()
        {
            System.Console.WriteLine("There are " + Person.NUM_PEOPLE + " with an average age of: " + Person.calculateAverageAge() + ".");
        }

        // Recap of various kinds of Method Signatures:
        //    int getName();								1.) Function with no parameters that returns a value. (The method name implies it's a "Getter")
        //    int calculateNetWorth();						2.) Function with no parameters that returns a value. (The method name implies it's a "Computed Value")
        //    int addAmount(10);							3.) Function with 1 parameter that returns a value. (This seems like it will mutate the state of the object)
        //    int addAmount(10, 15);						4.) Same as above except it takes two parameters, which makes it an overload of the previous method.
        //    static int calculateAverageAge();				5.) This seems like just another computed value, except it's static, so the class must invoke it.
        //    void setName(string name);					6.) This is a void method that is named "set" which implies it changes the name value inside the object.
        //    void setNameAndAge(string name, int age);		7.) The same as the above, except it takes two parameters, so it's changing two internal object values.
        //    void printNameAndAge();						8.) Void method with no parameters, which implies this is simply a reusable action for the instance objects.
        //    static void printAverageAge();                9.) Static void method, which implies it is a chunk of reusable code unrelated to instance objects.
    }
}
