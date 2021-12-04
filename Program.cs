using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
       {  
         int num1=0,num2=1,num3,i,number;    
         Console.Write("\nEnter the Number : "+"\n");    
         number = int.Parse(Console.ReadLine()+"\n");  
         Console.Write(num1+" "+num2+" "); //printing 0 and 1    
         for(i=2;i<number;++i) //loop starts from 2 because 0 and 1 are already printed    
         {    
          num3=num1+num2;    
          Console.Write(num3+" ");    
          num1=num2;    
          num2=num3;    
          //Console.WriteLine("\t");
         }    
      }  
   }  
}


/* In case of fibonacci series, next number is the sum of previous two numbers for example 0, 1, 1, 2, 3, 5, 8, 13, 21 etc. The first two numbers of fibonacci series are 0 and 1.

Let's see the fibonacci series program in C#. */