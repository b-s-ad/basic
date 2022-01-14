using System;

namespace SelSor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int[] arr = new int[] { 48, 85, 99, 10, 56 };

            System.Console.WriteLine("Selection Sort \nThe Array before is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
            int temp, min;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine();
            Console.WriteLine("sorted Array is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}