using System;

namespace stackll
{

    public class Stacks

    {

        static readonly int MAX = 10;

        int top;

        int[] stack = new int[MAX];


        public Stacks()

        {

            top = -1;

        }

        bool IsEmpty()

        {

            return (top < 0);

        }

        public bool Push(int data)//parateized methhod

        {

            if (top >= MAX)

            {

                Console.WriteLine("Stack is Overflow");

                return false;

            }

            else

            {

                stack[++top] = data;

                return true;

            }

        }



        public int Pop()

        {

            if (top < 0)

            {

                Console.WriteLine("Stack is Underflow");

                return 0;


            }
            else

            {

                int value = stack[top--];

                return value;

            }
            
        }



        public void Peek()

        {

            if (top < 0)

            {

                Console.WriteLine("Stack is Underflow");

                return;

          }

            else

                Console.WriteLine("The topmost element of Stack is : {0} ", stack[top]);

        }



        public void PrintStack()

        {

            if (top < 0)

            {

                Console.WriteLine("Stack is Underflow ");

                return;

            }

            else

            {

                Console.WriteLine("Items in Stack are :");

                for (int i = top; i >= 0; i--)

                {

                    Console.WriteLine(stack[i]);

                }

            }

        }

    }
}