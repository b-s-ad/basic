using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : E\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    string E = (i == 1 || i == 5 || i == 3 || j == 1 || j == 0) ? "*" : " ";
                    System.Console.Write(E);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}
