using System;
using System.Collections.Generic;
using System.Text;


namespace LinkedList
{
public class SinglyLinkedList
    {
       
   class Node
{
    public int info;
    public Node link;

    public Node (int data)
    {
        info = data;
        link = null;
    }

}   
      private Node head;


    public SinglyLinkedList()
    {
        head = null;
    }

        public void AddinEmptyList(int data)          ////////////////////Add Node
{
            Node temp = new Node(data);
            head=temp;

            Console.WriteLine("\n\nNode Added Successfully in List " + head.info);
//            Console.ReadLine();
}

public void Addlast(int data)  //////////////////////////  Add at last

{
Node p = head;
Node temp= new Node(data);
if(head==null)
{
head=temp;
return;
}
/* else
{
p.link = temp;
} */
while(p.link !=null)
{
p.link =temp;
}
p.link=temp;
Console.WriteLine("\n"+"Data Added At Last : ");
Console.WriteLine("\n");
}

public void AddBegin(int data)              // add begin
{
    Node temp = new Node(data);
    temp.link=head;
    head=temp;
}

public void display()                   //////////////////////Display
{
Node p =head;
while(p!=null)
{
    Console.WriteLine(p.info + "\n");
    p=p.link;
}

}
public void AtPosition(int data, int x) ///////////////////////add at position X
        {
            Node p = head;
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p == null)
                Console.WriteLine("Node is Not Present");
            else {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        
        }

        public void AddBefore(int data, int x)    //////////////add before
        {
            Node p = head;
            while(p!=null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            Node temp = new Node(data);
            temp.link = p.link;
            p.link = temp;
        }


 public bool SearchNode(int key)
        {
            Node p = head;
            if (head == null)
            {
                 return false;
            }
            while (p.info != key) 
            {
                if (p.link == null)
                {
                    break;
                }
                p = p.link;
            }
            if (p.info == key)
            {
                Console.WriteLine("\n"+"Node is Found"+"\n");
                if(head==null)
                //return;
                head = head.link;
                return true;
            }
            else
            {
                Console.WriteLine("\n"+"Node is Not Found"+"\n");
                return false;
            }
        }


       
 
public void removeLast()
        {
            if (head == null)
                return;
            if (head.link == null)
            {
                head = null;
                return;
            }
            Node p = head;
            while (p.link.link != null)
            {
                p = p.link;
            }
            p.link = null;
        }

        public void RemoveAnyNode(int x)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            if (head.info == x)
            {
                head = head.link;
                return;
            }

            Node p = head;
            while(p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            if(p.link==null)
            {
                Console.WriteLine("Node not in list");
            }
            else
            {
                p.link = p.link.link;
            }
        }

        public void DeleteFirst()
        {
            if(head==null)
                return;
            head = head.link;
        }



        }



    
}




