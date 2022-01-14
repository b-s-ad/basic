using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   //User Input
                Console.Clear();
                Console.WriteLine("The Bubble Sort User Input :\n\nThe Number of Array (Bubble Sort) : ");
                int input = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[input];
                System.Console.WriteLine($"Enter [{input}] element  of Array (Bubble Sort) : ");
                for (int i = 0; i < input; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                /* ********************************************************** */

                int temp;
                int n = arr.Length;
                //System.Console.WriteLine("Program Starts");
                System.Console.WriteLine("\nArray Sort : ");

                foreach (var item in arr)
                {
                    System.Console.Write(" " + item);
                    //Console.ReadLine();                
                }
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
                System.Console.WriteLine("\n\nAfter Sorted : \n");
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
                System.Console.WriteLine("\n");
            }

            catch (System.Exception)
            {
                System.Console.WriteLine("\nINVALID INPUT AS STRING");
            }
        }
    }

}