namespace Example3_Statics
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher.Count = 0;      // Initialize the static variable Teacher.Count to 0.
            Student.Count = 0;      // Initialize the static variable Student.Count to 0.

            Teacher theTeacher = new Teacher();     // Declare and instantiate a Teacher object.
            theTeacher.Name = "Donnie Santos";      // Assign the value of the member variable "Name".
            Teacher.Count++;                        // Increment the value of static variable Teacher.Count.

            Student student1 = new Student();       // Declare and instantiate a Student object.
            student1.Name = "John Doe";             // Assign the value of the member variable "Name".
            student1.Grade = "B";                   // Assign the value of the member variable "Grade".
            Student.Count++;                        // Increment the value of static variable Student.Count.

            Student student2 = new Student();       // Declare and instantiate a Student object.
            student2.Name = "Jane Doe";             // Assign the value of the member variable "Name".
            student2.Grade = "A";                   // Assign the value of the member variable "Grade".
            Student.Count++;                        // Increment the value of static variable Student.Count.

            System.Console.WriteLine("Teachers: " + Teacher.Count);     // Print out static Teacher.Count.
            System.Console.WriteLine("Students: " + Student.Count);     // Print out static Student.Count.
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}