using System;
using static System.Console;
using static System.ConsoleColor;
using System.Linq;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Clear();
   //Integer
             List<int>numberlist=new List<int>();
            numberlist.Add(35);
            numberlist.Add(20);
            numberlist.Add(46);
            numberlist.Add(45);
            numberlist.Add(60);
            numberlist.Add(50); 
  //string
            List<String>author=new List<String>();
            author.Add("Dot net");
            author.Add("Java");
            author.Add("Swift");
            author.Add("NodeJs");
            author.Add("Php");
            author.Add("C++");
  //display
            ForegroundColor=Magenta;WriteLine("Number List\n");      
            foreach (var item in numberlist)           
            {
                System.Console.WriteLine(item);
            }WriteLine("\n");//ReadKey();
            ForegroundColor=Cyan;WriteLine("Author List\n");
            foreach (var item in author)           
            {
                System.Console.WriteLine(item);
            }WriteLine("\n");//ReadKey();
  //collection to list
            ForegroundColor=Red;WriteLine("collection List\n");
            string[] animal = {"cat","cow","bird","fly","insect"};
            List<String>animalList=new List<String>();
            animalList.AddRange(animal);
            foreach (var item in animalList)
            System.Console.WriteLine(item);
            WriteLine("\n");//ReadKey();
  //Remove item from list
            ForegroundColor=Green;;WriteLine("[Remove item from list] :\n");
            animalList.Remove("cat");
            foreach (var item in animalList)
            System.Console.WriteLine(item);
            WriteLine("\n");//ReadKey();
  //RemoveAT using the position
            ForegroundColor=Yellow;WriteLine("[RemoveAT using the position] :\n");
            animalList.RemoveAt(1);
            foreach (var item in animalList)
            System.Console.WriteLine(item);
            WriteLine("\n");//ReadKey();
  //how to insert the element at position in list
            ForegroundColor=Blue;WriteLine("[how to insert the element at position in list] :\n");
            animalList.Insert(3,"Added1");
            animalList.Insert(1,"Added2");
            foreach (var item in animalList)
            System.Console.WriteLine(item);
            WriteLine("\n");//ReadKey();
  //Sort a C# List elements
            ForegroundColor=DarkMagenta;WriteLine("[Before Sorting] :\n");
            foreach (var item in author)       
            System.Console.WriteLine(item);
            System.Console.WriteLine("\n");
            author.Sort();System.Console.WriteLine("[After Sorting] : \n");
            foreach (var item in author)       
            System.Console.WriteLine(item);
 //Reverse           
            ForegroundColor=DarkCyan;
            author.Reverse();WriteLine("\n[Reverse view] : \n");
            foreach (var item in author)       
            System.Console.WriteLine(item);
 //Find the element 
            ForegroundColor=Green;
            var find = author.IndexOf("NodeJs,4");
            WriteLine($"\nFind the element : ");
            if (find>0)
                    {
                    Console.WriteLine($"Value Not found in the list");
                    }
                    else
                    {
                        System.Console.WriteLine($"Value is Found in list");
                    }
                    System.Console.WriteLine("-----------------");

            List<int> num = new List<int>();
            num.Add(20);
            num.Add(4);
            num.Add(8);
            num.Add(16);
            num.Add(40);
            num.Add(88);

            IEnumerable<int>data =from n in num where n>10 select n;
            System.Console.WriteLine("Linq with collections \n");
            foreach (var item in data)
            {
               System.Console.WriteLine("Element in list : "+item); 
            }System.Console.WriteLine("-----------------");
            




        }
    }
}
