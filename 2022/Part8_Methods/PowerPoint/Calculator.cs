namespace Part8_Methods.PowerPoint
{
    class Calculator
    {
        public double addTwoNumbers(double x, double y)
        {
            return x + y;
        }

        public double addThreeNumbers(double x, double y, double z)
        {
            double sumOfFirstTwo = this.addTwoNumbers(x, y);
            double totalSum = this.addTwoNumbers(sumOfFirstTwo, z);
            return totalSum;
        }
    }
}