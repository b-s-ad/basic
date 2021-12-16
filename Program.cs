using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)

            {
            DoublyLinkedList obj2 = new DoublyLinkedList();
            Console.Clear();
            //obj2.push(95);
            obj2.push(40);                       
            Console.Write("\n");
            obj2.AddLast(30);            
            Console.ReadKey();
            Console.Clear();

            // find the Node found or not
            Console.WriteLine("Enter Node to be search : "); /// search node
            obj2.SearchNode(int.Parse(Console.ReadLine())); // user input search node ///////////////////   10
            Console.ReadKey();
            Console.Clear(); 


            //sorting
            System.Console.WriteLine("Sort Element in list\n");
            obj2.Sorting(obj2.head);
            Console.ReadKey();
            Console.Clear();
            // Insert to middle
            obj2.Inserttomiddle(40,140);
            obj2.ddisplay();
            Console.ReadKey();
            Console.Clear();

            //obj2.middle_node();
            //Remove the Last Node
            /*  System.Console.WriteLine("Remove the Last Node\n");
            obj2.removeLast();
            obj2.ddisplay();     */

            //Remove the 1st Node
            // System.Console.WriteLine("Remove the First Node\n");
            // obj2.DeleteFront();
            //obj2.ddisplay();  



}
    }

}