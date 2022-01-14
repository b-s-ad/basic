using System;

namespace selsoruser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("The Selection Sort User Input :\n\nThe Number of Array : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[input];
            System.Console.WriteLine($"Enter [{input}] element  of Array : ");
            for (int i = 0; i < input; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* *************************************************************** */
            //int [] arr = new int[]{10,56,48,85,99};

            System.Console.WriteLine("The Array before is : ");
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
