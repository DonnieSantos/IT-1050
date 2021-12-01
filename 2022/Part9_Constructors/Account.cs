namespace Part9_Constructors
{
    class Account
    {
        private string accountNumber;

        // Here we define our own constructor.
        // A Constructor in C#:
        //     1.) Is a method with the same name as the class.
        //     2.) Has no return type.
        // By defining this or any constructor, we remove the default constructor.
        // The default constructor is auto-generated and invisible if no constructor is defined.
        // For example we never wrote constructors before, so we would get "new Account()" for free.
        // By defining this constructor that has a different signature, "new Account()" won't compile.
        // We must pass a string when we instantiate each object.
        // There are no rules for the code you can put in the constructor's logic, HOWEVER...
        // It is *usually* used to simply initialize the member variable values, such as is shown here.
        // I added the WriteLine just to show that you can write anything you like in the constructor.

        public Account(string accountNumber)
        {
            this.accountNumber = accountNumber;
            IO.WriteLine("Account No. " + this.accountNumber + " has been created.");
        }

        public string getAccountNumber()
        {
            return this.accountNumber;
        }
    }
}
