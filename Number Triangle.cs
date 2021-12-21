using System;

namespace ANumber_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
           int  i,j,k,l,n;           
       Console.Write("Enter the Range=");    
       n= int.Parse(Console.ReadLine());     
       for(i=1; i<=n; i++)      
       {          
        for(j=1; j<=n-i; j++)      
        {      
         Console.Write(" ");      
        }      
        for(k=1;k<=i;k++)      
        {      
         Console.Write(k);      
        }      
        for(l=i-1;l>=1;l--)      
        {      
        Console.Write(l);      
        }      
        Console.Write("\n");      
       }       
   }  
  }  
}

/* 
C# Program to print Number Triangle

Like alphabet triangle, we can write the C# program to print the number triangle. 
The number triangle can be printed in different ways. */