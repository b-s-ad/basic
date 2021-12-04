using System;

namespace oddeven
{
    class Program
    {
    public static void Main(string[] args)  
    {
        int n;
        //console.Console.Clear();
        
        Console.WriteLine("\nEnter a number to check : ","\n");


            n = Convert.ToInt32(Console.ReadLine());

            
            if ((n / 2) * 2 == n)
            {
                Console.WriteLine("\tit is even number : " +n);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\tit is odd number : " +n);
                Console.ReadKey();
            }
        }
    }
}