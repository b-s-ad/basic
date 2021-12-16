using System;
using static System.Console;

namespace stackll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stacks obj = new Stacks();
            Clear();
            obj.Push(10); //LIFO // 1st in store last place to remove
            obj.Push(20);
            obj.Push(30);
            obj.Push(40); // Last in store in 1st place to remove
            obj.PrintStack();
            ReadKey();//Clear();
            obj.Peek();
            ReadKey();
            WriteLine("\nItem popped from Stack : {0}\n", obj.Pop());
            obj.PrintStack();
            ReadKey();
        }
    }
}
