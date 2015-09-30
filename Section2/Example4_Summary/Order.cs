namespace Example4_Summary
{
    class Order
    {
        public string FirstName;
        public string LastName;

        public int Tortilla;
        public int Carnitas;
        public int TacoShells;
        public int Rice;
        public int Steak;
        public int Chicken;
        public int Barbacoa;
        public int Guacamole;
        public int SourCream;
        public int Beans;
        public int Cheese;
        public int CornSalsa;
        public int Fajita;
        public int OtherSalsa;

        public void GatherDataFromUser()
        {
            this.FirstName = Question.AskForString("First Name");
            this.LastName = Question.AskForString("Last Name");
            this.Chicken = Question.AskForInteger("How many orders of chicken");
            this.Carnitas = Question.AskForInteger("How many orders of carnitas");
            this.Steak = Question.AskForInteger("How many orders of steak");
            this.Barbacoa = Question.AskForInteger("How many orders of barbacoa");
            this.Beans = Question.AskForInteger("How many orders of beans");
            this.Cheese = Question.AskForInteger("How many orders of cheese");
            this.Fajita = Question.AskForInteger("How many orders of fajita");
            this.Tortilla = Question.AskForInteger("How many orders of flour tortilla");
            this.TacoShells = Question.AskForInteger("How many orders of taco shells");
            this.Rice = Question.AskForInteger("How many orders of rice");
            this.SourCream = Question.AskForInteger("How many orders of sour cream");
            this.Guacamole = Question.AskForInteger("How many orders of guacamole");
            this.CornSalsa = Question.AskForInteger("How many orders of corn salsa");
            this.OtherSalsa = Question.AskForInteger("How many orders of other salsa");
        }

        public int GetTotalCalories()
        {
            int totalMealCalories = 0;

            totalMealCalories += this.Chicken * Calories.Chicken;
            totalMealCalories += this.Carnitas * Calories.Carnitas;
            totalMealCalories += this.Steak * Calories.Steak;
            totalMealCalories += this.Barbacoa * Calories.Barbacoa;
            totalMealCalories += this.Tortilla * Calories.Tortilla;
            totalMealCalories += this.TacoShells * Calories.TacoShells;
            totalMealCalories += this.Rice * Calories.Rice;
            totalMealCalories += this.Beans * Calories.Beans;
            totalMealCalories += this.Fajita * Calories.Fajita;
            totalMealCalories += this.Guacamole * Calories.Guacamole;
            totalMealCalories += this.SourCream * Calories.SourCream;
            totalMealCalories += this.Cheese * Calories.Cheese;
            totalMealCalories += this.CornSalsa * Calories.CornSalsa;
            totalMealCalories += this.OtherSalsa * Calories.OtherSalsa;

            return totalMealCalories;
        }
    }
}