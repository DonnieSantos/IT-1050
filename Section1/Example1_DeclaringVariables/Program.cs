namespace Example1_DeclaringVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // A double slash creates a "comment".
            // Comments are ignored by the compiler.

            // +==================================================================================+
            // | So, now I will declare a few variables.                                          |
            // | The syntax of a variable declaration is always a type followed by a name.        |
            // | The type must be known by the language, but the name can be anything you want.   |
            // | The name has to be one word, though. And it can't start with a number.           |
            // | Also, don't forget that every instruction must end with a semi-colon.            |
            // +==================================================================================+

            // +==================================================================================+
            // | The following line of code declares a variable named "teamName".                 |
            // | The type of this variable is "string".                                           |
            // | A string is a series of characters (symbols) with no inherent meaning.           |
            // +==================================================================================+

            string teamName;

            // +==================================================================================+
            // | Now that I have declared the variable, the word "teamName" will have meaning.    |
            // | The compiler will understand "teamName" to mean the location of a string value.  |
            // | We can change the value, but "teamName" always refers to the same location.      |
            // | Since we declared "teamName" as a string, it can ONLY contain string values.     |
            // | You cannot, for example, put a numeric value into the teamName variable.         |
            // +==================================================================================+

            // +==================================================================================+
            // | The following line of code declares a variable named "numberOfPlayersOnTeam".    |
            // | The type of this variable is "int".                                              |
            // | The "int" type means the variable can store an integer value.                    |
            // | Integers are numbers with no decimal place, such as 1, 2, 3, 4, 5, 10, etc.      |
            // +==================================================================================+

            int numberOfPlayersOnTeam;

            // +==================================================================================+
            // | The following line of code declares a variable named "teamBattingAverage".       |
            // | The type of this variable is "float".                                            |
            // | Floats are numbers that allow decimal places, such as 1.25, 3.5, 5.001, etc.     |
            // +==================================================================================+

            float teamBattingAverage;

            // +==================================================================================+
            // | Two other interesting variable types are "long" and "double"                     |
            // | A long is the same as an integer, but it has extra memory for bigger numbers.    |
            // | A double is the same as a float, but it has extra memory for longer decimals.    |
            // +==================================================================================+

            long someReallyHugeInteger;
            double someReallyLongDecimal;

            // +==================================================================================+
            // | The following line of code declares a variable of type "bool".                   |
            // | Variables of type "bool" only have two possible values: true or false.           |
            // +==================================================================================+

            bool isDoorClosed;

            // +==================================================================================+
            // | For a complete list of available variable types in C#...                         |
            // | Just search the Microsoft MSDN Library for their current documentation.          |
            // | https://msdn.microsoft.com/en-us/library/ya5y69ds.aspx                           |
            // +==================================================================================+
        }
    }
}