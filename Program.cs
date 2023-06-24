using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueUsingLL
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Stack<int> stack = new Stack<int>();

            //Adds an Element 
            Console.WriteLine("The pushed elements in stack are : ");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Display();

            //Removes an Element
            Console.WriteLine("The elements after pop are : ");
            stack.Pop();
            stack.Display();

            //Returns top most Element
            stack.Peek();

            //Checks if stack is Empty
            stack.IsEmpty();
            
            //Checks the Size of Stack
            stack.Size();
            
        }
    }
}