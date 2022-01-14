using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : J\n");
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    string J = (i == 1 || j == 5 || i > 7 && j <= 5||i==1) ? "*" : " ";
                    System.Console.Write(J);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}

