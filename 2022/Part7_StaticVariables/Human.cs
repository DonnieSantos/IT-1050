namespace Part7_StaticVariables
{
    class Human
    {
        public string firstName;                        // Every Human has a firstName.
        public string lastName;                         // Every Human has a lastName. (Except for Zendaya)
        public bool isMarried;                          // Every Human is either married or not.
        public int age;                                 // Every Human has an age.

        public static string species = "Homo Sapien";   // All Humans are the same species. ("Homo Sapien")
        public static bool warmBlooded = true;          // All Humans are warmBlooded.
        public static int count;                        // There is only one variable that counts all Humans.
    }
}
