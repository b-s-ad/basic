using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;

namespace Demo
{
    class Person
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
        public DateTime DOB { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var PersonList = new ArrayList();

            PersonList.Add(new Person { ID = 0012, Name = "User", Age = 22, Salary = 30000, DOB = DateTime.Parse(Convert.ToString("01-01-1998")) });
            PersonList.Add(new Person { ID = 001, Name = "User2", Age = 44, Salary = 45600, DOB = DateTime.Parse(Convert.ToString("11-1-1998")) });
            PersonList.Add(new Person { ID = 002, Name = "User3", Age = 66, Salary = 56300, DOB = DateTime.Parse(Convert.ToString("12-5-1998")) });
            PersonList.Add(new Person { ID = 003, Name = "User4", Age = 77, Salary = 85200, DOB = DateTime.Parse(Convert.ToString("4-5-1998")) });
            PersonList.Add(new Person { ID = 004, Name = "User5", Age = 88, Salary = 45200, DOB = DateTime.Parse(Convert.ToString("5-6-1998")) });
            PersonList.Add(new Person { ID = 005, Name = "User6", Age = 99, Salary = 95100, DOB = DateTime.Parse(Convert.ToString("8-4-1998")) });
            PersonList.Add(new Person { ID = 006, Name = "User7", Age = 11, Salary = 56300, DOB = DateTime.Parse(Convert.ToString("8-1-1998")) });



            //var query = (from Person p in PersonList where p.Age == 22  select p).Average(e=>e.Salary);   
            var Average = (from Person p in PersonList select p).Average(avg => avg.Salary);      // AVG
            var Max = (from Person p in PersonList select p).Max(max => max.Salary);                // MAX
            var Min = (from Person p in PersonList select p).Min(min => min.Salary);               // MIN
            var DOBB = from Person p in PersonList select p;                                // DOB 
            bool any = (from Person p in PersonList select p).Any(any => any.Salary >= 99300);     // ANY


            System.Console.WriteLine("The Average Value is : " + Average);
            System.Console.WriteLine("\nThe Max Value is : " + Max);
            System.Console.WriteLine("\nThe Min value is : " + Min + "\n");
            foreach (var item in DOBB) { System.Console.WriteLine("Printing DOB : " + item.DOB); }
            System.Console.WriteLine($"\nThe Value is found : [{any}]");
            Console.ReadKey();

        }
    }


}