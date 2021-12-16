using System;

namespace queues
{
    class CreateQueue {

    public int max =2;
    
    public int front;

    public int rear;

    public int[] queue; 
 

    public CreateQueue(int size)

    {

        queue = new int[size];

        front = 0;

        rear = -1;

        max=size;

         

        
    }

 
public void isEmpty()

    {

        if (rear == front)
         {

            Console.WriteLine("Queue is Empty");

        }

    } 

    public void enqueue(int x)

    {

        if (rear == max - 1) 
        {

            Console.WriteLine("queue size limit is reached | OverFlow");
                return;
             }

        else {

            queue[++rear] = x;
            Console.WriteLine(x + " is added into queue");

        }

    }

    public int dequeue()

    {

        if (front == rear +1) 
        {

            Console.WriteLine("Queue is Empty"); 
            return -1;          

        }

        else 
        {
        int x = queue[+front];
        Console.WriteLine("\n****\n"+queue[front] + " dequeued from queue");
        Console.WriteLine();
        Console.WriteLine("Front item is {0}", queue[++front]);
        Console.WriteLine("Rear item is {0} ", queue[rear]);
        return x;
            

        }

    }

public void printQueue()
    {
        if (front == rear + 1) {
            Console.WriteLine("Queue is Empty");
            return;
        }
        else {
            for (int i = front; i <= rear; i++) 
            {
                Console.WriteLine(queue[i] + " enqueued to queue");
            }
        }

}}
}