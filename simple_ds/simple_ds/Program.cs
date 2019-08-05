using System;

namespace simple_ds
{
    class Program
    {
        static void Main(string[] args)
        {
            Structures.Stack<int> stack = new Structures.Stack<int>();

            Console.WriteLine(stack.isEmpty());
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
        }
    }
}
