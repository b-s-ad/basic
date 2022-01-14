using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : D\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    string D = (i == 1 || i == 5 || j == 2 || j == 5) ? "*" : " ";
                    System.Console.Write(D);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}
