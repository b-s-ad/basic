using System;
using System.Collections.Generic;
using  static System.ConsoleColor;

namespace dic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Clear();
            Dictionary<String,String> EmployeeList = new Dictionary<string, string>(){   //<String,String>
            {"Bill gates", "Winwows"},{"Amazon", "Flipkart"},{"Dot net", "C#"},{"C", "C++"}, {"Java", "JVM"}};   

            Dictionary<String,Int16> AuthorList = new Dictionary<String, Int16>(){      //<String,Int16>       
            {"Mahesh", 34},{"Node", 44},{"stack", 54},{"queue", 94}};           
            
            Dictionary<String,float> PriceList = new Dictionary<string, float>(){       // <String,float>
            {"Tea",2.45f},{"Sugar",2.35f},{"Water",2.25f},{"Coffee",2.15f}};            
                   
//1.2.//***Display using for each***      
         // Display  EmployeeList <String,String>
          Console.ForegroundColor=Cyan;        
          Console.WriteLine("\t1.ADD & 2.Display\n"+"\n-----------------"+"\nEmployeeList <String,String>\n");
          foreach(KeyValuePair<String,String> employee in EmployeeList)  
          {            
              Console.WriteLine("{0} -><- {1}", employee.Key, employee.Value);
          }   Console.ReadKey(); //Console.Clear();
          
          // Display  AuthorList <String,Int16>  
          Console.ForegroundColor=Magenta;
          Console.WriteLine("\n-----------------"+"\nDisplay  AuthorList <String,Int16>\n");

          foreach(KeyValuePair<String,Int16> author in AuthorList)
          {            
              Console.WriteLine("{0} -><- {1}", author.Key, author.Value);
          }   Console.ReadKey();//Console.Clear();
          // Display  PriceList <String,float>  
          Console.ForegroundColor=Green;
          Console.WriteLine("\n-----------------"+"\nDisplay  PriceList <String,float>\n");  
          foreach(KeyValuePair<String,float> price in PriceList)  
          {
              
              Console.WriteLine("{0} -><- {1}", price.Key, price.Value);
          }   Console.ReadKey();//Console.Clear();
/***********************************************************************/
//3.count
            Console.ForegroundColor=DarkYellow;
            System.Console.WriteLine("\n-----------------"+"\n\t3.Get number of elements in a C# dictionary[Count]");
            System.Console.WriteLine("\nEmployeeList Count: {0}", EmployeeList.Count);
            System.Console.WriteLine("AuthorList Count: {0}", AuthorList.Count);
            System.Console.WriteLine("PriceList Count: {0}\n", PriceList.Count);
            System.Console.WriteLine("-----------------");
            Console.ReadKey(); //Console.Clear();
/***********************************************************************/            
//4. Get a Dictionary item

                // Get Item value
                Int16 age = Convert.ToInt16(AuthorList["Mahesh"]);
                // Set Item value
                AuthorList["Mahesh"] = 20;
                Console.ForegroundColor=DarkCyan;
                System.Console.WriteLine("\n\t4.Get/Set a Dictionary item\n");
                foreach(KeyValuePair<String,Int16> author in AuthorList)           
                Console.WriteLine("{0} -><- {1}", author.Key, author.Value);
                System.Console.WriteLine("-----------------");
                Console.ReadKey(); //Console.Clear();
/***********************************************************************/                
//5.Get the collection of keys of C# Dictionary                
                Dictionary<string, Int16>.KeyCollection keys = AuthorList.Keys;
                Console.ForegroundColor=DarkGreen;
                System.Console.WriteLine("\n\t5.Get the collection of keys of C# Dictionary\n");
                foreach (string key in keys) 
                {
                Console.WriteLine("AuthorList Key : {0}", key);
                }System.Console.WriteLine("-----------------");
                Console.ReadKey(); //Console.Clear();
/***********************************************************************/   
//6.Get the collection of values of a C# Dictionary              
                // Get and display values
                Dictionary<string, float>.ValueCollection values = PriceList.Values;
                Console.ForegroundColor=DarkMagenta;
                System.Console.WriteLine("\n\t6.Get the collection of values of a C# Dictionary\n");
                foreach (float val in values)
                {
                Console.WriteLine("PriceList Value [float] : {0}", val);
                }System.Console.WriteLine("-----------------");
                Console.ReadKey(); //Console.Clear();
/***********************************************************************/
//7.Remove elements from a C# dictionary  
                Console.ForegroundColor=DarkGreen;
                System.Console.WriteLine("\n\t7.Remove elements from a C# dictionary\n");
                System.Console.WriteLine("EmployeeList Count: {0}", EmployeeList.Count);
                EmployeeList.Remove("Bill gates");//remove bill gates
                System.Console.WriteLine("EmployeeList Count: {0}", EmployeeList.Count);
                System.Console.WriteLine("-----------------");
                Console.ReadKey(); //Console.Clear();
/***********************************************************************/
//8.Remove all items
                Console.ForegroundColor=Gray;
                System.Console.WriteLine("\n\t8.Remove all items\n");
                System.Console.WriteLine("PriceList Count: {0}", PriceList.Count);
                PriceList.Clear();
                System.Console.WriteLine("PriceList Count: {0}", PriceList.Count);
                System.Console.WriteLine("-----------------");
                Console.ReadKey(); //Console.Clear();
/***********************************************************************/
//9.Find a Key in a Dictionary
                    Console.ForegroundColor=Magenta;
                    System.Console.WriteLine("\n\t9.Find a Key in a Dictionary\n");
                    if (!AuthorList.ContainsKey("SRK")) { ///searhing 
                    AuthorList["SRK"] = 120;
                    }foreach(KeyValuePair<String,Int16> author in AuthorList)           
                    Console.WriteLine("{0} -><- {1}", author.Key, author.Value);    
                    System.Console.WriteLine("-----------------");
                    Console.ReadKey(); //Console.Clear();
/***********************************************************************/
//10.Find a Value in a Dictionary
                    Console.ForegroundColor=DarkGreen;
                    System.Console.WriteLine("\n\t10.Find a Value in a Dictionary\n");
                    if (!AuthorList.ContainsValue(44))
                    {
                    Console.WriteLine("Value Not found");
                    }
                    else
                    {
                        System.Console.WriteLine("Value is Found");
                    }
                    System.Console.WriteLine("-----------------");
                    //Console.ReadKey(); //Console.Clear();
/***********************************************************************/


        }
    }

}
