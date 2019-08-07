using System;
using System.Collections.Generic;

namespace simple_ds.Structures
{
    class Queue<T>
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
    }
}
