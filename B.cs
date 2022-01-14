using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : B\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    string B = (i == 1 || i == 3 || i == 5 || j == 1 || j == 5) ? "*" : " ";
                    System.Console.Write(B);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}
