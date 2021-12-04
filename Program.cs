using System;
using static System.Console;


namespace prime1toAny

{
    class Program
    {
         public static void Main()
        {
            int i = 2;
            Clear();
            WriteLine("\nFind the 1 to 100(Any) prime number using while loop : \n");
            int k=int.Parse(Console.ReadLine());
            while (i < k)
            {
                bool count = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count = true;
                        break;
                    }
                }
                if (count == false)
                {
                    Write(i + " ");
                }
                i++;
            }
            ReadLine();
        }
    }
}