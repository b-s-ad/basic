using System;
using static System.Console;
using  static System.ConsoleColor;

namespace perfect_n    /*that number is equal to that number. For example 6 is perfect number since divisor of 6 are 1, 2 and 3.*/
                       /*Sum of its divisor is 1 + 2+ 3 = 6*/
{
    class Program
    {
        static void Main(string[] args)
            {  
                    Clear();
                    int number,sum=0,n;
                    WriteLine("Enter the Number : ");
                    n = int.Parse(ReadLine());
                     
                    for (int i = 1; i < n;i++)
                    {
                    if (n % i == 0)
                    {
                    sum=sum + i;
                    }
                    }
                    if (sum == n)

                    {
                    Console.ForegroundColor=Blue;
                    WriteLine(n+" is a perfect number");
                    ReadLine();
                    }
                    else
                    {
                    Console.ForegroundColor=Magenta;
                    WriteLine(n+" is not a perfect number");
                    ReadLine();
                    }
            }
    }
}
