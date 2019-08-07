using System;
using System.Collections.Generic;

namespace simple_ds.Structures
{
    public class Queue<T>
    {
        private int size_of_queue;
        private readonly List<T> queue_data;
        public Queue()
        {
            size_of_queue = 0;
            queue_data = new List<T>();
        }

        //add new element at the end of queue
        public void Enqueue(T new_item)
        {
            ++size_of_queue;
            queue_data.Add(new_item);
        }

        //return size of a queue
        public int Size()
        {
            return size_of_queue;
        }

        //check if queue is empty
        public bool isEmpty()
        {
            if (size_of_queue == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //return first element of queue without remowing it
        public T Top()
        {
            if (isEmpty())
            {
                throw new Exception("Cannot find firs element on queue. Queue is empty");
            }
            else
            {
                return queue_data[0];
            }
        }

        //return first element of queue and delete it
        public T Dequeue()
        {
            var top_item = Top();
            queue_data.Remove(top_item);
            --size_of_queue;
            return top_item;
        }

        //clear queue
        public void Clear()
        {
            queue_data.Clear();
        }

        //return a deep clone object
        public Queue<T> Copy()
        {
            Queue<T> clone_queue = new Queue<T>();
            
            for (var element = 0; element < size_of_queue; ++element)
            {
                clone_queue.Enqueue(queue_data[element]);
            }

            return clone_queue;
        }

        //sort values in this queue (bubble sort) TODO
        public void Sort()
        {
            for (var step_by_each_symbol = size_of_queue - 1; step_by_each_symbol > 0; --step_by_each_symbol)
            {
                for (var one_symbol = 0; one_symbol < step_by_each_symbol; ++one_symbol)
                {

                    if (Convert.ToInt32(queue_data[one_symbol]) > Convert.ToInt32(queue_data[one_symbol + 1]))
                    {
                        T buffer;

                        buffer = queue_data[one_symbol + 1];
                        queue_data[one_symbol + 1] = queue_data[one_symbol];
                        queue_data[one_symbol] = buffer;
                    }
                }
            }
        }

        //reverse values position in the queue
        public Queue<T> Reverse()
        {
            Queue<T> reversed_queue = new Queue<T>();
            Queue<T> buffer_queue = new Queue<T>();
            Stack<T> buffer_stack = new Stack<T>();

            buffer_queue = this.Copy();

            while (!buffer_queue.isEmpty())
            {
                buffer_stack.Push(buffer_queue.Dequeue());
            }

            while (!buffer_stack.isEmpty())
            {
                reversed_queue.Enqueue(buffer_stack.Pop());
            }

            return reversed_queue;
        }

        //reverse first n item in a queue
        public Queue<T> Reverse(int n)
        {
            Queue<T> reversed_queue = new Queue<T>();
            Queue<T> buffer_queue = new Queue<T>();
            Stack<T> buffer_stack = new Stack<T>();

            buffer_queue = this.Copy();

            for (var item = 0; item < n; ++item)
            {
                buffer_stack.Push(buffer_queue.Dequeue());
            }

            while (!buffer_stack.isEmpty())
            {
                reversed_queue.Enqueue(buffer_stack.Pop());
            }

            while (!buffer_queue.isEmpty())
            {
                reversed_queue.Enqueue(buffer_queue.Dequeue());
            }

            return reversed_queue;
        }
    }
}
