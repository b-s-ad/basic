using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : M\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    string M = (j == 1 || j == 5 || i == 2 && j >= 2 && j <= 2 || i == 3 && j >= 3 && j <= 3 || i == 2 && j >= 4 && j <= 4) ? "*" : " ";
                    System.Console.Write(M);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}

