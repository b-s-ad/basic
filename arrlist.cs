using System;
using static System.Console;
using System.Collections;
using  static System.ConsoleColor;



namespace arrlist
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Hello World!");
                Clear();Console.ForegroundColor=Cyan;
                ArrayList list = new ArrayList();
                list.Add("XYZ");
                list.Add("CDE");
                list.Add("ABC");
                list.Add("JKL");
                list.Add("MNO");
                list.Add("PQR");
                list.Add("STR");                  
                show(list);

                //Sort list
                Console.ForegroundColor=Magenta;
                System.Console.WriteLine("After Sorting : ");
                list.Sort();show(list);   


                //Remove the element
                Console.ForegroundColor=Green;
                System.Console.WriteLine("\nRemove the element : ");            
                list.Remove("XYZ");
                show(list);         

                //Remove Range element per Index
                Console.ForegroundColor=Blue;
                System.Console.WriteLine("Remove  Range element per Index : "); 
                list.RemoveRange(1,3);//After 1 ,three ele removed
                show(list); 

                //RemoveAT Element  after index 1
                Console.ForegroundColor=DarkYellow;
                System.Console.WriteLine("RemoveAT Element  after index : ");
                list.RemoveAt(1);
                show(list);



         }
                public static void show(IEnumerable list)
                { 
                foreach (var item in list)
                {
                Console.Write(" {0} " ,item);
                Console.WriteLine();
                }WriteLine("\n");
        }
    }
}
