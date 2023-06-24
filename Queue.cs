using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueUsingLL
{
    internal class Queue<T>
    {
        Node<T> head;
        Node<T> tail;

        public void Enqueue(T data)
        { 
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            { 
                newNode.next = tail;
                tail = newNode;
            
            }
        
        }


        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            if (head == tail)
            {
                Console.WriteLine("Dequeued item from Queue is : " + head.data);
                head = null;
                tail = null;
                return;
            }

            Console.WriteLine("Dequeued item from Queue is : " + head.data);
            head = head.next;
        }


        public void Peek()
        {
            if (head == null)
            {
                Console.WriteLine("The Queue is Empty");

            }
            Console.WriteLine("The element at the head is : " + head.data);
            Console.WriteLine();
        }



        public void IsEmpty()
        {
            if (head == null)
            {
                Console.WriteLine("The Queue is Empty");
            }
            else
            {
                Console.WriteLine("The Queue is not Empty");
            }
            Console.WriteLine();

        }




        public void Size()
        {
            int count = 0;

            Node<T> temp = tail;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("The size of Queue is : " + count);
            Console.WriteLine();
        }



        public void Display() 
        {
            Node<T> temp = tail;
            while (temp != null) 
            {
                Console.Write(temp.data + "=>");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
