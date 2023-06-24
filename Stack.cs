using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueUsingLL
{
    internal class Stack<T>
    {
        Node<T> top;



        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (top == null)
            {
                top = newNode;
            }

            else
            {
                newNode.next = top;
                top = newNode;
            }

        }


        public T Pop()
        {
            if (top == null)
            {
                Console.WriteLine("The Stack is empty!!!");
                return default(T);
            }


            T PopData = top.data;
            top = top.next;
            return PopData;
        }


        public void Peek()
        {

            Console.WriteLine("The Data on top is : " + top.data);
            Console.WriteLine();

        }


        public void IsEmpty()
        {
            if (top == null)
            {
                Console.WriteLine("The Stack is Empty");
            }
            else
            {
                Console.WriteLine("The Stack is Not Empty");
            }
            Console.WriteLine();

        }

        public void Size()
        {
            int count = 0;

            Node<T> temp = top;
            while (temp != null) 
            {
                count++;
                temp=temp.next;
            }
            Console.WriteLine("The size of Stack is : " + count);
            Console.WriteLine();
        }


        public void Display() 
        {
            Node<T> temp = top;

            while (temp != null) 
            {
                Console.WriteLine(temp.data);
               temp=temp.next;
            }
            Console.WriteLine();
        }

    }
}
