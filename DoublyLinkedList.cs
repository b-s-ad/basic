using System;

namespace LinkedList
{
    public class DoublyLinkedList
    {

       public Node head;

      /*  public DoublyLinkedList()
        {
            Node head;

        }  */
        public class Node
        {
            public int data;
            public Node next;
            public Node prev;

            

            int temp_data;

            public Node(int d)
            {
                data = d;
                
                next = null;
            }

            

        public Node()
{

    //data=temp_data;
}
 
        }




        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            {
                new_node.next = head;
                new_node.prev = null;
            };
            //new_node.next = head;

            if (head != null)
            {
                head = new_node;
            }
            head = new_node;

            System.Console.WriteLine("First Node is Added : " + head.data);

        }

        public void AddLast(int new_Data)
        {
            Node new_node = new Node(new_Data);
            {
                Node last = head;
                new_node.next = null;

                new_node.next = null;
                if (head == null)
                {
                    new_node.prev = null;
                    head = new_node;
                    return;
                }
                while (last.next != null)
                {
                    last = last.next;
                }
                last.next = new_node;
                new_node.prev = last;
                System.Console.WriteLine("Last Node is Added : "  + new_node.data);
            }




        }
       
        
       public void ddisplay()                   //////////////////////Display
     {
          
            while(head!=null)
     {
            Console.WriteLine(head.data + "\t");
            head=head.next
            ;
    }

    }

public void removeLast() //delete last
        {
            if (head != null)
                
            if (head.next == null)
            {
                head = null;
                //return;
            }
                
        else
        {
            Node temp = new Node() ;
            temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            Node lastNode=temp.next;
            
            lastNode = null;
            temp.next =null;
        }
    }


public void InsertAfter(Node prev_Node, int new_data)
    {
 
        /*1. check if the given prev_node is NULL */
        if (prev_Node == null)
        {
            Console.WriteLine("The given previous node cannot be NULL ");
            return;
        }
 
        /* 2. allocate node
        * 3. put in the data */
        Node new_node = new Node(new_data);
 
        /* 4. Make next of new node as next of prev_node */
        new_node.next = prev_Node.next;
 
        /* 5. Make the next of prev_node as new_node */
        prev_Node.next = new_node;
 
        /* 6. Make prev_node as previous of new_node */
        new_node.prev = prev_Node;
 
        /* 7. Change previous of new_node's next node */
        if (new_node.next != null)
            new_node.next.prev = new_node;
            System.Console.WriteLine("Node is Added in Middle" + head);
    }

 public void Sorting(Node node)
    {
        Node last = null;
        Console.WriteLine("Traversal in forward Direction");
        while (node != null) {
            Console.Write(node.data + " ");
            last = node;
            node = node.next;
        }
        Console.WriteLine();
        Console.WriteLine("Traversal in reverse direction");
        while (last != null) {
            Console.Write(last.data + " ");
            last = last.prev;
        }
    }


public void DeleteFront()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else if (head.next == null)
            {
                head = null;
            }
            else
            {
                head.data = head.next.data;
                head.next = head.next.next;
            }
        }


public bool SearchNode(int key)
        {
            Node p = head;
            if (head == null)
            {
                 return false;
            }
            while (p.data != key) 
            {
                if (p.next == null)
                {
                    break;
                }
                p = p.next;
            }
            if (p.data == key)
            {
                Console.WriteLine("\n"+"Node is Found"+"\n");
                if(head==null)
                //return;
                head = head.next;
                return true;
            }
            else
            {
                Console.WriteLine("\n"+"Node is Not Found"+"\n");
                return false;
            }
        }

public void middle_node() {

		if (head != null) {
			Node slow = head, fast = head;

			while (fast != null && fast.next != null && fast.next.next != null) {
				slow = slow.next;
				fast = fast.next.next;
    			}

			Console.Write("\n Middle : " + slow.data+ "\n");
		} else {

			Console.Write("Empty linked list");
		}
	}
   

   public bool Inserttomiddle(int key,int data)
        {
            Node current = head;                                                                                            
            while (current.data != key)
            {
                if (current.next == null)
                {
                    break;
                }
                current = current.next;
            }
            if (current.data == key)
            {
                Node newNode = new Node(data);
                newNode.next = current.next;
                current.next = newNode;
                Console.WriteLine("Node is added to middle\n");
                return true;
            }
            else
            {
                Console.WriteLine("Node is not found");
                return false;
            }
        }

}
}