using System;
using System.Collections.Generic;

namespace simple_ds.Structures
{
    public class Stack<T>
    {
        private int size_of_stack;
        private readonly List<T> stack_data;

        //initialization of a stack
        public Stack()
        {
            size_of_stack = 0;
            stack_data = new List<T>();
        }

        //return size of a stack
        public int Size()
        {
            return size_of_stack;
        }

        //check if stack is empty
        public bool isEmpty()
        {
            if (size_of_stack == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // return top element of a stack without remowing it
        public T Peek()
        {
            if (isEmpty())
            {
                throw new Exception("Cannot peek the top element. Stack is empty");
            }
            else
            {
                return stack_data[size_of_stack - 1];
            }
        }

        //add new item on top of a stack (NOTE: top of a stack it is actually last element of a list)
        public void Push(T new_item)
        {
            ++size_of_stack;
            stack_data.Add(new_item);
        }

        //return top element of a stack and remowe it
        public T Pop()
        {
            if (this.isEmpty())
            {
                throw new Exception("Cannot pop the top element. Stack is empty");
            }
            else
            {
                var top_item = this.Peek();              
                stack_data.Remove(top_item);
                --size_of_stack;
                return top_item;
            }
        }

        // reverse the caller stack (turn a stack into a queue)
        public void Reverse()
        {
            Stack<T> buffer_stack = new Stack<T>();

            buffer_stack = this.Copy();

            this.Clear();
            while (!buffer_stack.isEmpty())
            {
                this.Push(buffer_stack.Pop());
            }

        }

        //return a deep copy of a stack
        public Stack<T> Copy()
        {
            Stack<T> copyed_stack = new Stack<T>();

            for (var element = 0; element < size_of_stack; ++element)
            {
                copyed_stack.Push(stack_data[element]);
            }

            return copyed_stack;
        }

        //sort values in this stack (bubble sort) TODO
        public void Sort()
        {
            for (var step_by_each_symbol = size_of_stack - 1; step_by_each_symbol > 0; --step_by_each_symbol)
            {
                for (var one_symbol = 0; one_symbol < step_by_each_symbol; ++one_symbol)
                {
                    
                    if (Convert.ToInt32(stack_data[one_symbol]) > Convert.ToInt32(stack_data[one_symbol + 1]))
                    {
                        T buffer;

                        buffer = stack_data[one_symbol + 1];
                        stack_data[one_symbol + 1] = stack_data[one_symbol];
                        stack_data[one_symbol] = buffer;
                    }
                }
            }
        }

        //clear stack
        public void Clear()
        {
            stack_data.Clear();
            size_of_stack = 0;
        }
    }
}
