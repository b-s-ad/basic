using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : N\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    //string M = (j == 1 || j == 5 || i == 2 && j >= 0 && j <= 2 || i == 3 && j >= 3 && j <= 5 || i == 1 && j >= 8 && j <= 4) ? "*" : " ";
                    string N = (j == 1 || j == 5 || i == 2 && j >= 2 && j <= 2 || i == 3 && j >= 3 && j <= 3) ? "*" : " ";
                    System.Console.Write(N);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}

