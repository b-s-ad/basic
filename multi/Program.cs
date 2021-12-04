using System;

namespace multi
{
    public interface student1  // interface method (does not have a body)
    {
        void Test();
        void Show();
    }
    public interface student2
    {
        void Test();
        void Show();
    }
    class Result : student1, student2   // Result "implements" the student interface
    {
        public void Test()
        {
            Console.WriteLine("Test method is implemented");
        }
        public void Show()
        {
            Console.WriteLine("Show mwthod is implemented");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Result obj = new Result();////////////////////////
            obj.Test();
            obj.Show();
            Console.WriteLine("\n");
            student1 s1 = new Result(); ///////////////////////
            s1.Test();
            s1.Show();
            Console.WriteLine("\n");
            student2 s2 = new Result(); ///////////////////////
            s2.Test();
            s2.Show();
            Console.WriteLine("\nPress any key to exist ");
            Console.ReadKey();
        }
    }
}