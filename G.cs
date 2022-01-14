using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("\nAlphabet_pattern : G\n");
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    string G = (i == 1 || j == 1 || i == 7 || j == 5 && i >= 4 || i == 3 && j >= 3) ? "*" : " ";
                    System.Console.Write(G);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
            System.Console.WriteLine("\nAlphabet_pattern : G\n");
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    string G = (i == 1 || j == 1 || i == 7 || j == 5 && i >= 4 || i == 3 && j >= 3 || j == 3 && i >= 2 && i <= 3) ? "*" : " ";
                    System.Console.Write(G);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
            System.Console.WriteLine("\nAlphabet_pattern : G\n");
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    //string G = ( i==1||j==1||i==7||j==5 && i>=4||i==3&&j>=3||j==3&&i>=2&&i<=4)  ? "*" : " ";
                    string G = (i == 1 || j == 1 || i == 7 || j == 5 && i >= 4 || i == 3 && j >= 3 || j == 3 && i >= 3 && i <= 4) ? "*" : " ";
                    System.Console.Write(G);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
            System.Console.WriteLine("\nAlphabet_pattern : G\n");
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    string G = (i == 1 || j == 1 || i == 7 || j == 5 && i >= 4 || i == 3 && j >= 3 || j == 3 && i >= 2 && i <= 4) ? "*" : " ";
                    System.Console.Write(G);
                }
                System.Console.WriteLine();
            }
            /* ***************************************************** */
        }
    }
}

