using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Stacks store data in the same ways as arrays, EXCEPT
             *      data can only be inserted, read, or removed from the END/TOP
             *      
             * Good resource/tool for handling temporary data or 
             *      processing data that should be handled in reverse -> recursion!
            */


            // Can access the stack class directly from System.Collections
            // Declare what data type your stack will hold --> can be any
            Stack<int> myStack = new Stack<int>();

            // Add items to TOP of stack
            myStack.Push(0);
            myStack.Push(2);
            myStack.Push(4);
            myStack.Push(6);
            myStack.Push(8);


            /* What stack would look like...
             * -------------------------------
             * |  0  |  2  |  4  |  6  |  8  |
             * -------------------------------
             * LIFO Can we access ANY number?
             * 2?  4?  Why or why not?
            */

            /* Also visually think of it like this...STACKED
             * ------
             *  8
             * ------
             *  6
             * ------
             *  4
             * ------
             *  2
             * ------
             *  0
             * ------
             */

            // To see all the items within the stack -> need to loop
            Console.WriteLine("My stack to start: ");
            foreach (int num in myStack)
                Console.WriteLine(num);
            Console.WriteLine();

            // Count property counts num of items within stack
            myStack.Count();

            //Console.WriteLine("There are " + myStack.Count() + " items in the stack");
            //Console.WriteLine();

            //// Peek at TOP item in stack -> what would each of these READ?
            //Console.WriteLine("Peeking at: " + myStack.Peek());
            //Console.WriteLine("Peeking at: " + myStack.Peek());
            //Console.WriteLine("Peeking at: " + myStack.Peek());
            //Console.WriteLine();

            // 8, 8, 8

            // Remove items from TOP of stack -> what would each of these RETURN?
            //myStack.Pop();
            //myStack.Pop();

            //// Let's see what popped off...
            //Console.WriteLine("Popped off: " + myStack.Pop());
            //Console.WriteLine("Popped off: " + myStack.Pop());
            //Console.WriteLine();
            // 8, 6


            // What's left inside stack now?  Can access through a loop
            Console.WriteLine("What's left in the stack now?");
            foreach (int num in myStack)
                Console.WriteLine(num);

            Console.ReadLine();
        }
    }
}
