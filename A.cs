using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : A\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    string A = (i == 1 || i == 3 || j == 1 || j == 5) ? "*" : " ";
                    System.Console.Write(A);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */

        }
    }
}
