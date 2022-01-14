using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : C\n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    string C = (i == 1 || i == 5 || j == 1 || j == 1) ? "*" : " ";
                    System.Console.Write(C);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}
