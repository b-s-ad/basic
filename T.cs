using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : T\n");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    string T = (i == 1 || j == 5 ||i==1) ? "*" : " ";
                    System.Console.Write(T);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}

