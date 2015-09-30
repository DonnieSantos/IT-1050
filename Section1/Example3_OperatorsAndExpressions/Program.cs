namespace Example3_OperatorsAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // +==================================================================================+
            // |                                                                                  |
            // |                                   C# Operators                                   |
            // |                                                                                  |
            // | Assignment                                                                       |
            // |      The ASSIGNMENT Operator                                                 =   |
            // |      The INCREMENT ASSIGNMENT Operator                                       +=  |
            // |      The DECREMENT ASSIGNMENT Operator                                       -=  |
            // |                                                                                  |
            // | Arithmetic                                                                       |
            // |      The ADDITION Operator (Also String Concatenation)                       +   |
            // |      The SUBTRACTION Operator                                                -   |
            // |      The MULTIPLICATION Operator                                             *   |
            // |      The DIVISION Operator                                                   /   |
            // |      The INCREMENT Operator                                                  ++  |
            // |      The DECREMENT Operator                                                  --  |
            // |                                                                                  |
            // | Boolean                                                                          |
            // |      The AND Operator                                                        &&  |
            // |      The OR Operator                                                         ||  |
            // |      The NOT Operator                                                        !   |
            // |      The EQUAL Operator                                                      ==  |
            // |      The NOT EQUAL Operator                                                  !=  |
            // |      The GREATER THAN Operator                                               >   |
            // |      The LESS THAN Operator                                                  <   |
            // |      The GREATER THAN OR EQUAL TO Operator                                   >=  |
            // |      The LESS THAN OR EQUAL TO Operator                                      <=  |
            // |                                                                                  |
            // | Complete MSDN List: https://msdn.microsoft.com/en-us/library/6a71f45d.aspx       |
            // |                                                                                  |
            // +==================================================================================+

            int number;             // Variable Declaration. (int)                      [0]
            number = 10;            // Value Assignment of Literal Integer.             [10]
            number += 10;           // Increment Variable Value.                        [20]
            number -= 5;            // Decrement Variable Value.                        [15]
            number = 50 + 50;       // Value Assignment of Arithmetic Expression.       [100]
            number = 10 - 10;       // Value Assignment of Arithmetic Expression.       [0]
            number = 100 * 2;       // Value Assignment of Arithmetic Expression.       [200]
            number = 100 / 2;       // Value Assignment of Arithmetic Expression.       [50]
            number++;               // Increment Variable Value.                        [51]
            number--;               // Decrement Variable Value.                        [50]

            bool OK;                // Variable Declaration. (bool)                     [false]
            OK = true && false;     // Value Assignment of Boolean Expression.          [false]
            OK = true || false;     // Value Assignment of Boolean Expression.          [true]
            OK = !true;             // Value Assignment of Boolean Expression.          [false]
            OK = 1 == 2;            // Value Assignment of Boolean Expression.          [false]
            OK = 1 != 2;            // Value Assignment of Boolean Expression.          [true]
            OK = 25 > 200;          // Value Assignment of Boolean Expression.          [false]
            OK = 25 < 200;          // Value Assignment of Boolean Expression.          [true]
            OK = 25 >= 26;          // Value Assignment of Boolean Expression.          [false]
            OK = 25 <= 25;          // Value Assignment of Boolean Expression.          [true]

            // +==================================================================================+
            // | Expressions can get complicated. You can use parenthesis to enforce precedence.  |
            // +==================================================================================+

            double weightOfCarInTons = ((4 * 10) + (4 * 100) + 3000 + 1000) / 2000;

            // +==================================================================================+
            // | Another useful trick is to break down expressions into smaller variables.        |
            // | This is known as a more "semantic" approach. A little easier to read maybe?      |
            // +==================================================================================+

            double weightOfTires = 4 * 10;
            double weightOfSeats = 4 * 100;
            double weightInternal = 3000;
            double weightOfBody = 1000;
            double totalPounds = weightOfTires + weightOfSeats + weightInternal + weightOfBody;
            weightOfCarInTons = totalPounds / 2000;

            // +==================================================================================+
            // | One more thing... The + Operator can also concatenate strings together.          |
            // +==================================================================================+

            int xCoordinate = 10;
            int yCoordinate = 20;
            string formattedPoint = "[" + xCoordinate + "," + yCoordinate + "]";
        }
    }
}