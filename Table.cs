using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : Table \n");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    string Table = (i == 1 || i + j == 6 || j - i == 4) ? "*" : " ";

                    System.Console.Write(Table);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}

