using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : K\n");
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 6; j++)
                {

                    //string 7 = ( i == 1 ||i+j==6||j-i==4) ? "*" : " ";
                    string K = (j == 1 || i + j == 6 || i - j == 3) ? "*" : " ";
                    System.Console.Write(K);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}

