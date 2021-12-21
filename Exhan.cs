using System;
using System.Collections.Generic;
using System.Linq;

namespace ExHand
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Clear();
            
            
            try
            {
             //   string name = null;
             //   Console.WriteLine(name.Length);

                int a = 100;
                int b = 0;
                int c = a / b;
            }
           
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)   // Global Exception or Parent Exception of Other catch Block 
            {
                Console.WriteLine(ex.Message);
            }
            finally
        {
            System.Console.WriteLine("\nThe Execution is completed\n");
        }

        }
    }
}
