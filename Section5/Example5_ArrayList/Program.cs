using Example4_ClassLibraries;
using System.Collections;

namespace Example5_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            while (Question.AskForString("Add Another Item? (y/n)").ToLower().StartsWith("y"))
            {
                Widget widget = GetNewWidget();
                list.Add(widget);
            }

            foreach (Widget widget in list)
            {
                widget.Print();
            }

            System.Console.ReadKey();
        }

        private static Widget GetNewWidget()
        {
            Widget widget = new Widget();
            widget.SetID(Question.AskForInteger("Item Number"));
            widget.SetDescription(Question.AskForString("Item Description"));
            return widget;
        }
    }
}