using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : F\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    string F = (i == 3 || i == 1 || j == 1 || j == 0) ? "*" : " ";
                    System.Console.Write(F);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}
