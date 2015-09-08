namespace Example2_ObjectMethods
{
    class Person
    {
        public string FirstName;        // Member (Instance) Variable Declaration (Noun)
        public string MiddleInitial;    // Member (Instance) Variable Declaration (Noun)
        public string LastName;         // Member (Instance) Variable Declaration (Noun)
        public int Age;                 // Member (Instance) Variable Declaration (Noun)

        // +======================================================================================+
        // | The following is a Member (Instance) Method Declaration/Definition.                  |
        // | A method is an "Action" or a "Behavior" or a "Verb".                                 |
        // | The primary purpose of methods is CODE REUSE so you don't write the same code twice. |
        // | You can define the method once, then "Invoke" it as many times as you need.          |
        // | Just like member variables, all objects of this type can "Invoke" this method.       |
        // | If a method has a non-void type, like the one below, it must end with a "return".    |
        // | The "return" will end the method invocation by supplying an output value.            |
        // +======================================================================================+

        public string GetFullName()
        {
            // Remember, you can always use the "this" keyword to access member variables.
            // It's optional, but it makes it explicit that the variable is part of this object.
            // Otherwise, it may be confusing as to where the variable actually exists.

            string fullName = "";
            fullName += this.FirstName;
            fullName += " ";
            fullName += this.MiddleInitial;
            fullName += ". ";
            fullName += this.LastName;
            return fullName;
        }

        // +======================================================================================+
        // | Some methods have the type of "void".                                                |
        // | This means the method does not conclude with an output value.                        |
        // | As such, there can be no return statement at the end of the definition.              |
        // +======================================================================================+

        public void StateYourNameAndAge()
        {
            System.Console.WriteLine(this.FirstName + " says, 'Hello'.");
            System.Console.WriteLine("My name is " + this.GetFullName());
            System.Console.WriteLine("My age is " + this.Age);
        }
    }
}