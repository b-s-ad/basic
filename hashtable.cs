using System;
using System.Collections;
using static System.Console;


namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Clear();            
            Hashtable ht= new Hashtable();
            //Hashtable.Add("Key","Value");
            ht.Add("001","c");
            ht.Add("002","C++");
            ht.Add("003","C#");
            ht.Add("004","Dotnet");
            ht.Add("005","Python");
            ht.Add("006","Java");
            
            System.Console.WriteLine("Display element : "+ht.Count + "\n");
 
            ICollection keys = ht.Keys; // to get list of hashtable
            //Display All
            foreach (var val in keys)            
            Console.WriteLine(val + "-" + ht[val]);
            ReadKey(); 

            System.Console.WriteLine("======\n"+"Displaying After Remove (Key) : "+"\n");
            ht.Remove("001");ht.Remove("003");ht.Remove("006");//REMOVING KEY
           
            foreach (var val in keys)            
            Console.WriteLine(val + "-" + ht[val]);
            System.Console.WriteLine("======\nRemoved Element : "+ht.Count);
            ReadKey();//ht.Clear();

            //bool
            System.Console.WriteLine("======\n" + ht.ContainsKey("005"));//ContainsKey
            System.Console.WriteLine(ht.ContainsValue("C++"));//ContainsValue

            /* foreach (var val in keys)            
            Console.WriteLine(val + "-" + ht[val]); */                        
        }
    }
}
