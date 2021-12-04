using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            SinglyLinkedList obj  = new SinglyLinkedList();
            obj .AddinEmptyList(20);  /// add starting             1
            //obj.display();
            //Console.ReadKey();
            obj.Addlast(144); /// add at last                      2
            
            obj.display();
            Console.ReadKey();
            
            Console.Clear();

            //obj.DeleteFirst(); //////////////////////////////////////////////////remove FIrst Node   3
            //obj.removeLast(); ///////////////////////////////////////remove last node                 4               
            //obj.display(); // display


            obj.AddBegin(456); /////////////////////////////////////////// add at 1st upper          5                        
            /*  
            string x;  // string            ////////////////////////////////////////////////////       6
            Console.WriteLine("Enter the position or Press Enter :" + "\n"); // ATposition / add before value
            x=(Console.ReadLine() + "\n");  // string
            */
            /* 
            int x; //////////////////////////////////////////////////////////////////////////////    7
            Console.WriteLine("Enter the position :" + "\n"); // ATposition / add before value
            x=int.Parse(Console.ReadLine() + "\n");  //int
            */
           
            obj.AtPosition(520 , 144); // (data is 520 AFTER position is 20) /////////////////////// 8
            obj.AddBefore(201,20);// (data is 201 BEFORE position is 20) /////////////////////////////   9
             
            //obj.display(); // Display last result
            // obj.SearchNode(120); // hard coded value                         /////////////////       10       
            System.Console.WriteLine("\nAt Positon / Add before / add begin\n");
            obj.display(); 
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Enter Node to be search : "); /// search node
            obj.SearchNode(int.Parse(Console.ReadLine())); // user input search node ///////////////////   10
            Console.ReadKey();
            Console.Clear(); 
            #region 
            obj.display();
            System.Console.WriteLine("VIew All \n");
            Console.ReadKey();
            Console.Clear();
            System.Console.WriteLine("Remove Node / Delete 1st / Delete Last");
            obj.RemoveAnyNode(520);//////////////////remove AnY Node ////////////////////////       11
            obj.display();
            #endregion

             Console.ReadKey();
             Console.Clear();  
             System.Console.WriteLine("DeleteFirst \n"); 
             obj.DeleteFirst();
             obj.display();
             Console.ReadKey(); //////////////////////////////////////////////////remove FIrst Node   3
             Console.Clear();
             System.Console.WriteLine("DeleteLast \n");
             obj.removeLast(); ///////////////////////////////////////remove last node                 4               
             obj.display(); // display
        }

    }
}