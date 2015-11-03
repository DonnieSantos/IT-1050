namespace Example4_ClassLibraries
{
    public class Widget
    {
        private int _id;
        public int GetID() { return _id; }
        public void SetID(int id) { _id = id; }

        private string _description;
        public string GetDescription() { return _description; }
        public void SetDescription(string description) { _description = description; }

        public void Print()
        {
            System.Console.WriteLine("[" + this.GetID() + "] " + this.GetDescription());
        }
    }
}