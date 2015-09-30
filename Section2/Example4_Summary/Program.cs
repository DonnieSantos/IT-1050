namespace Example4_Summary
{
    class Program
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order();
            myOrder.GatherDataFromUser();

            System.Console.WriteLine("Order Details For " + myOrder.FirstName + " " + myOrder.LastName + ".");
            System.Console.WriteLine("Your Total Calorie Count = " + myOrder.GetTotalCalories() + ".");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}