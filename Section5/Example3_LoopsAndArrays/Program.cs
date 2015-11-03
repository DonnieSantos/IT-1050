using System;
using Example4_ClassLibraries;

namespace Example3_LoopsAndArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = Question.AskForInteger("How many items do you want to add? ");

            Widget[] items = new Widget[count];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Widget();
                items[i].SetID(Question.AskForInteger("Item Number"));
                items[i].SetDescription(Question.AskForString("Item Description"));
            }

            foreach (Widget item in items)
            {
                item.Print();
            }

            Console.ReadKey();
        }
    }
}