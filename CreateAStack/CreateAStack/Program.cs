using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            int first =5;
            int last = 10;

            for (int i = first; i <= last; i++)
                stack.Push(i);

            stack.Clear();

            for (int i = first; i <= last; i++)
                Console.WriteLine(stack.Pop());

            Console.ReadLine();
        }

        public class Stack
        {
            private List<object> listStack = new List<object>();

            public void Push(object obj)
            {
                if (obj == null)
                    throw new InvalidOperationException("This object can't be null.");

                listStack.Add(obj);
            }

            public object Pop()
            {
                if (listStack.Count == 0)
                    throw new InvalidOperationException("There aren't any objects to pop off the stack!");

                var index = listStack.Count - 1;

                var lastObj = listStack[index];

                listStack.RemoveAt(index);

                return lastObj;
            }

            public void Clear()
            {
                listStack.Clear();
            }
        }
    }
}
