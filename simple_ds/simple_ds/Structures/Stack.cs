using System;
using System.Collections.Generic;

namespace simple_ds.Structures
{
    class Stack<T>
    {
        private int size_of_stack;
        private readonly List<T> stack_data;

        //initialization of a stack
        public Stack()
        {
            this.size_of_stack = 0;
            this.stack_data = new List<T>();
        }

        //check if stack is empty
        public bool isEmpty()
        {
            if (this.size_of_stack == 0)
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
            if (this.isEmpty())
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
            ++this.size_of_stack;
            this.stack_data.Add(new_item);
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
                this.stack_data.Remove(top_item);
                --this.size_of_stack;
                return top_item;
            }
        }
    }
}
