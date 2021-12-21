using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

namespace linqq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Clear();
            int[] scores = {10,20,30,40,50,60,70,80,90};
            
            
            //var ScoreQuery = from score in scores where score >20 select score;
            var ScoreQuery2 = from score2 in scores where score2 >=20 select score2;
            IEnumerable<int> ScoreQuery = from score in scores where score >20 select score;
            //var NameQuery = from n in Name where n.Contains('A') select n;

            foreach (var item in ScoreQuery)
            {Console.Write(item + " ");}   // > greater than                          
            WriteLine("\n");
            foreach (var item in ScoreQuery2)
            {Console.Write(item + " ");} 
            WriteLine("\n");  // // >=greater THAN equal to   

            string[] Name = {"Apple","Aerospace","Aeroplance","ball","bat","BAsket"};
            var NameQuery = from n in Name where n.Contains('A') select n;                       
            foreach (var item in NameQuery)
            {Console.Write(item + " ");}         
            WriteLine("\n");                       
        }
    }
}
