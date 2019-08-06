using System;

namespace simple_ds
{
    class Program
    {
        static void Main(string[] args)
        {
            Structures.Stack<int> stack = new Structures.Stack<int>();
            Structures.Stack<int> stack_queue = new Structures.Stack<int>();

            Console.WriteLine(stack.isEmpty());
            stack.Push(1);
            stack.Push(2);
            stack.Push(6);
            stack.Push(10);
            stack.Push(3);
            stack.Push(5);
            stack.Push(4);
            stack.Push(9);
            stack.Push(8);
            stack.Push(7);
            stack.Sort();
            Console.WriteLine(stack.Peek());
        }
    }
}
