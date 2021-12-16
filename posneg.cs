using System;

namespace posneg
{
     class Program
        {
            static void Main(string[] args)
            {
            Console.Clear();   
            int num;          
            Console.Write("Enter an integer : ");
            //num= Convert.ToInt32(Console.ReadLine());
            num=-43;

            if (num >= 0) // greater than equal to 0
            Console.WriteLine("{0} is a positive number.\n",num);
            else
            Console.WriteLine("{0} is a negative number. \n", num);
            }
        }
}
