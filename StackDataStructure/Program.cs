using System;

namespace StackDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            Console.WriteLine(stack.Peek());
            stack.Push(20);
            Console.WriteLine(stack.Peek());
            stack.Push(30);
            Console.WriteLine(stack.Peek());
            stack.Push(40);
            Console.WriteLine(stack.Peek());
            stack.Push(50);
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Count);

            Console.WriteLine(stack.Contains(30));
            Console.WriteLine(stack.Contains(1));

            stack.Clear();

            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is null");
            }
            else
            {
                Console.WriteLine(stack.Peek());
            }
        }
    }
}
