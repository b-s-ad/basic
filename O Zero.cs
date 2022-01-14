using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : O\n");
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    string O = (i == 1 || j == 1 || j == 6 || i == 6) ? "*" : " ";
                    System.Console.Write(O);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}

