namespace Example2_AssigningValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // +==================================================================================+
            // | Here are some examples of declaring simple variables and assigning values.       |
            // | I have shown some invalid as well as correct value assignments.                  |
            // | The "=" symbol is called the "assignment operator".                              |
            // | This is how C# places a value into a variable.                                   |
            // | The type of the value MUST match the type of the variable declaration.           |
            // | Every time you assign a value, it completely replaces the previous value.        |
            // +==================================================================================+

            string teamName;                    // Variable Declaration of type string.
            teamName = Cleveland Indians;       // Incorrect string Value Assignment.
            teamName = "Cleveland Indians";     // CORRECT string Value Assignment.

            int numberOfPlayersOnTeam;          // Variable Declaration of type int.
            numberOfPlayersOnTeam = "40";       // Incorrect int Value Assignment.
            numberOfPlayersOnTeam = 40.5;       // Incorrect int Value Assignment.
            numberOfPlayersOnTeam = 40;         // CORRECT int Value Assignment.

            long someHugeInteger;               // Variable Declaration of type int.
            someHugeInteger = "1000000000000";  // Incorrect long Value Assignment.
            someHugeInteger = 1000000000000.5;  // Incorrect long Value Assignment.
            someHugeInteger = 1000000000000;    // CORRECT long Value Assignment.

            float teamBattingAverage;           // Variable Declaration of type float.
            teamBattingAverage = ".333";        // Incorrect float Value Assignment.
            teamBattingAverage = .333;          // Incorrect float Value Assignment.
            teamBattingAverage = .333f;         // CORRECT float Value Assignment.

            double teamSluggingAverage;         // Variable Declaration of type double.
            teamSluggingAverage = ".666";       // Incorrect double Value Assignment.
            teamSluggingAverage = .666;         // CORRECT double Value Assignment.

            bool isDoorClosed;                  // Variable Declaration of type bool.
            isDoorClosed = yes;                 // Incorrect bool Value Assignment
            isDoorClosed = True;                // Incorrect bool Value Assignment
            isDoorClosed = "true";              // Incorrect bool Value Assignment
            isDoorClosed = true;                // CORRECT bool Value Assignment
            isDoorClosed = false;               // CORRECT bool Value Assignment

            // +==================================================================================+
            // | If you wish to make your code a little more concise, you can combine the         |
            // | variable declaration and the value assignment into one line of code. This is     |
            // | called a "compound statement", since one line of code is performing multiple     |
            // | instructions. This is a very common thing to do in C# programming.               |
            // +==================================================================================+

            string myName = "Donnie";
            int myWeight = 190;

            // +==================================================================================+
            // | Another important thing to note is that there are multiple kinds of values.      |
            // | The simplest kind of value is called a LITERAL.                                  |
            // | A literal is an explicit value, such as the number 10, or the string "Hello".    |
            // | A variable is a container for a value, but a variable is not a literal.          |
            // | This is because a variable value is not known until it is examined in memory.    |
            // +==================================================================================+

            int myScore = 99;                   // Assigning a literal value of 99 to a variable.
            int yourScore = 86;                 // Assigning a literal value of 86 to a variable.
            int highestScore = myScore;         // Assigning a variable value to a variable.

            // +==================================================================================+
            // | Notice we assigned the variable "highestScore" the value of "myScore".           |
            // | "myScore" is a variable of type int, which means it contains an integer value.   |
            // | But it is not literal, because we don't know the value until the program runs.   |
            // | When the program runs, the variable "myScore" will contain a value of 99.        |
            // | So, "highestScore" will be assigned a copy of that value, also 99.               |
            // | You should always know the difference between a literal and a variable value.    |
            // +==================================================================================+
        }
    }
}