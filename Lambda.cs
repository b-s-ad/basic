using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");Console.Clear();

            List<int> num = new List<int>();
            num.Add(20);
            num.Add(4);
            num.Add(8);
            num.Add(16);
            num.Add(40);
            num.Add(60);
            num.Add(80);
            num.Add(100);
            num.Add(110);
            num.Add(118);
            num.Add(120);
            num.Add(130);
            num.Add(150);
            num.Add(500);
            num.Add(1000);

            List<int> no = num.FindAll(b => (b % 10 == 0));
            System.Console.WriteLine("Divide");
            foreach (int item in no)
            {
               System.Console.Write(" "+item); 
            }
            System.Console.WriteLine("\n");
/* ************************************************************************************* */
            List<int> no2 = num.FindAll(b => (b > 110));
            System.Console.WriteLine("Greater than (b > 110)");
            foreach (int item in no2)
            {
               System.Console.Write(" "+item); 
            }
            System.Console.WriteLine("\n");
/* ************************************************************************************* */
            List<int> no3 = num.FindAll(b => (b < 100));
            System.Console.WriteLine("small than (b < 100)");
            foreach (int item in no3)
            {
               System.Console.Write(" "+item); 
            }
            System.Console.WriteLine("\n");
/* ************************************************************************************* */
            List<int> no4 = num.FindAll(b => (b >= 60));
            System.Console.WriteLine("Greater than equal to (b >= 60)");
            foreach (int item in no4)
            {
               System.Console.Write(" "+item);  
            }
            System.Console.WriteLine("\n");
/* ************************************************************************************* */
            List<int> no5 = num.FindAll(b => (b <= 40));
            System.Console.WriteLine("Greater than equal to (b <= 40)");
            foreach (int item in no5)
            {
               System.Console.Write(" "+item); 
            }
            System.Console.WriteLine("\n");
/* ************************************************************************************* */
            List<int> no6 = num.FindAll(b => (b != 100));
            System.Console.WriteLine("(b != 100)");
            foreach (int item in no6)
            {
               System.Console.Write(" "+item); 
            }
            System.Console.WriteLine("\n");
/* ************************************************************************************* */

        }
    }
}
