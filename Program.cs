using System;
using static System.Console;


namespace queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Clear();            
            CreateQueue q=new CreateQueue(4);  //(Size of Queue is 4 | | | | |)          
           
            q.enqueue(10);
            q.enqueue(20);
            q.enqueue(30);
            q.enqueue(40);
            q.enqueue(50);//queue size limit is reached | OverFlow
            q.enqueue(60);//queue size limit is reached | OverFlow
            q.enqueue(70);//queue size limit is reached | OverFlow
            q.printQueue();
            q.dequeue();// remove first in first out FIFO
            ReadKey();
            
        }
    }
}


