using System;

namespace bs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int[] arr = { 30, 20, 19, 13, 3, 52 };
            int temp;
            int n = arr.Length;
            System.Console.WriteLine("Program Starts");
            System.Console.WriteLine("\nbefore Sorting");

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
            System.Console.WriteLine("\nSorted : \n");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
                //Console.Read();
            }
        }

    }
}


