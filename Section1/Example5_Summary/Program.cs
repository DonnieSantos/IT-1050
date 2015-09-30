namespace Example5_Summary
{
    class Program
    {
        static void Main(string[] args)
        {
            // +==================================================================================+
            // | This section is for some variables with already known, unchanging values.        |
            // | Variables that never change their values can be marked as "const".               |
            // +==================================================================================+

            const int caloriesTortilla = 300;
            const int caloriesCarnitas = 220;
            const int caloriesTacoShells = 210;
            const int caloriesRice = 200;
            const int caloriesSteak = 190;
            const int caloriesChicken = 180;
            const int caloriesBarbacoa = 170;
            const int caloriesGuacamole = 170;
            const int caloriesSourCream = 120;
            const int caloriesBeans = 120;
            const int caloriesCheese = 100;
            const int caloriesCornSalsa = 80;
            const int caloriesFajita = 20;
            const int caloriesOtherSalsa = 20;

            // +==================================================================================+
            // | This section is for some variables in which I do not yet know the value.         |
            // | I need to collect these values from the user through the Console window.         |
            // +==================================================================================+

            string firstName;
            string lastName;

            int addTortilla;
            int addCarnitas;
            int addTacoShells;
            int addRice;
            int addSteak;
            int addChicken;
            int addBarbacoa;
            int addGuacamole;
            int addSourCream;
            int addBeans;
            int addCheese;
            int addCornSalsa;
            int addFajita;
            int addOtherSalsa;

            // +==================================================================================+
            // | Now I will start collecting the data I need to compute my meal calories.         |
            // +==================================================================================+

            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            System.Console.Write("How many orders of chicken are in your meal? ");
            addChicken = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many orders of carnitas are in your meal? ");
            addCarnitas = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many orders of steak are in your meal? ");
            addSteak = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many orders of barbacoa are in your meal? ");
            addBarbacoa = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many orders of beans are in your meal? ");
            addBeans = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many orders of cheese are in your meal? ");
            addCheese = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many orders of fajita are in your meal? ");
            addFajita = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many orders of flour tortilla are in your meal? ");
            addTortilla = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many orders of taco shells are in your meal? ");
            addTacoShells = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many orders of rice are in your meal? ");
            addRice = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many orders of sour cream are in your meal? ");
            addSourCream = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many orders of guacamole are in your meal? ");
            addGuacamole = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many orders of corn salsa are in your meal? ");
            addCornSalsa = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many orders of other salsa are in your meal? ");
            addOtherSalsa = int.Parse(System.Console.ReadLine());

            // +==================================================================================+
            // | Now I have all the data I need to compute my total meal calorie count.           |
            // +==================================================================================+

            int totalMealCalories = 0;

            totalMealCalories += addChicken * caloriesChicken;
            totalMealCalories += addCarnitas * caloriesCarnitas;
            totalMealCalories += addSteak * caloriesSteak;
            totalMealCalories += addBarbacoa * caloriesBarbacoa;
            totalMealCalories += addTortilla * caloriesTortilla;
            totalMealCalories += addTacoShells * caloriesTacoShells;
            totalMealCalories += addRice * caloriesRice;
            totalMealCalories += addBeans * caloriesBeans;
            totalMealCalories += addFajita * caloriesFajita;
            totalMealCalories += addGuacamole * caloriesGuacamole;
            totalMealCalories += addSourCream * caloriesSourCream;
            totalMealCalories += addCheese * caloriesCheese;
            totalMealCalories += addCornSalsa * caloriesCornSalsa;
            totalMealCalories += addOtherSalsa * caloriesOtherSalsa;

            // +==================================================================================+
            // | Finally, I can output my meal details to the Console window.                     |
            // +==================================================================================+

            System.Console.WriteLine("Order Details For " + firstName + " " + lastName + ".");
            System.Console.WriteLine("Your Total Calorie Count = " + totalMealCalories + ".");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}