using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : X\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    string X = (i + j == 6 || j - i == 0) ? "*" : " ";
                    System.Console.Write(X);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}
