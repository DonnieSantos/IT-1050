namespace Part8_Methods.PowerPoint
{
    class CalculatorUse
    {
        public void CalculatorUseExample()
        {
            Calculator calculator = new Calculator();

            double sum1 = calculator.addTwoNumbers(10, 15);
            double sum2 = calculator.addThreeNumbers(25, 25, 50);

            System.Console.WriteLine("[" + sum1 + "," + sum2 + "]");

            // Or just...

            System.Console.WriteLine(calculator.addThreeNumbers(5, 8, 2));
        }
    }
}