using System;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            Stack stack = new Stack();

            Console.WriteLine("Pushing elements onto the stack:");
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Peek: " + stack.Peek());

            Console.WriteLine("Popping elements from the stack:");
            while (!stack.IsEmpty())
            {
                Console.WriteLine("Popped: " + stack.Pop());
            }
        }
    }
}
