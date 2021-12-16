using System;
using static System.Console;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            int n,Isprime;
            System.Console.WriteLine("Enter the Number : ");
            n=int.Parse(ReadLine());//1,3,7,11,13,17,19
            Isprime=0;
            for (int i = 2; i < n/2; i++)
            {
                if (n%i==0)
                {
                    Isprime=1;
                    break;
                }
            }
            if (Isprime==0)
            {
            WriteLine("This is Prime Number");                
            }
            else
            {
            WriteLine("This is NOT Prime Number");    
            }

        }
    }
}
