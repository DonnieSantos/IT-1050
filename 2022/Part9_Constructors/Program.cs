namespace Part9_Constructors
{
    // Account accountWithNoNumber = new Account();  <--- This will not compile.
    // This will not work because by defining the constructor(s) specifically,
    // we have lost the automatically-generated (and invisible) default constructor.
    // The default constructor is now gone, so "new Account()" won't compile.
    // The only constructor defined in Account.cs MUST take one string as a parameter.
    // Therefore we must use "new Account(string)" such that we pass a string value.
    // That is the ONLY available constructor, so we must use it to create an Account.

    class Program
    {
        static void Main(string[] args)
        {
            example1();
            example2();
            example3();
            example4();
        }

        static void example1()
        {
            // The constructor can return the new object's location to store in a variable.

            Account firstAccount = new Account("123456789");
            Account secondAccount = new Account("987654321");

            IO.Wait();
        }

        static void example2()
        {
            // The constructor can return the new object's location to treat as a plain value.

            Account[] accounts = { new Account("A1"), new Account("B1"), new Account("C1") };

            foreach (Account account in accounts)
            {
                IO.WriteLine("Account " + account.getAccountNumber() + " found.");
            }

            IO.Wait();
        }

        static void example3()
        {
            Person person1 = new Person();
            Person person2 = new Person(43);
            Person person3 = new Person("Donnie", 43);

            person1.DisplayNameAndAge();
            person2.DisplayNameAndAge();
            person3.DisplayNameAndAge();

            IO.Wait();
        }

        static void example4()
        {
            MarkedUpPerson person1 = new MarkedUpPerson();
            MarkedUpPerson person2 = new MarkedUpPerson(43);
            MarkedUpPerson person3 = new MarkedUpPerson("Donnie", 43);

            person1.DisplayNameAndAge();
            person2.DisplayNameAndAge();
            person3.DisplayNameAndAge();

            IO.Wait();
        }
    }
}
