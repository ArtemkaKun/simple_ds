using System;
using System.Collections.Generic;

namespace simple_ds.Structures
{
    public class DoubleLinkedList<T>
    {
        private int size_of_list;
        private readonly List<DoubleNode<T>> list_data;
        private DoubleNode<T> head;
        private DoubleNode<T> tail;

        public DoubleLinkedList()
        {
            size_of_list = 0;
            list_data = new List<DoubleNode<T>>();
            head = null;
            tail = null;
        }

        public int Size()
        {
            return size_of_list;
        }

        public bool isEmpty()
        {
            if (Size() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T PeekHead()
        {
            if (!isEmpty())
            {

                return head.get_node_data();
            }
            else
            {
                throw new Exception("Cannot peek head. Stack is empty!");
            }
        }

        public T PeekTail()
        {
            if (!isEmpty())
            {
                return tail.get_node_data();
            }
            else
            {
                throw new Exception("Cannot peek tail. Stack is empty!");
            }
        }

        public void PushBack(T item)
        {
            
            if (head == null)
            {
                list_data.Add(new DoubleNode<T>(item, null, null));
                ++size_of_list;
                head = list_data[0];
                tail = list_data[0];
            }
            else
            {
                list_data.Add(new DoubleNode<T>(item, null, list_data[size_of_list - 1]));
                ++size_of_list;
                tail.set_next_node(list_data[size_of_list - 1]);
                tail = list_data[size_of_list - 1];
            }
        }

        public void PushStart(T item)
        {
            ++size_of_list;
            list_data.Add(new DoubleNode<T>(item, head, null));
            head = list_data[size_of_list - 1];
        }

        public void Clear()
        {
            size_of_list = 0;
            list_data.Clear();
            head = null;
            tail = null;
        }

        public T GetElementFromStart(int id)
        {
            var item = head;
            for (var elem = 0; elem < id - 1; ++elem)
            {
                item = item.get_next_node();
            }

            return item.get_node_data();
        }

        public T GetElementFromBack(int id)
        {
            var item = tail;
            for (var elem = 0; elem < id - 1; ++elem)
            {
                item = item.get_previous_node();
            }

            return item.get_node_data();
        }

        public T RemoveHead()
        {
            if (!isEmpty())
            {
                var value = PeekHead();
                head = head.get_next_node();
                --size_of_list;
                return value;
            }
            else
            {
                throw new Exception("Cannot remove head. List is empty!");
            }
        }

        public T RemoveTail()
        {
            if (!isEmpty())
            {
                var value = PeekTail();
                tail = tail.get_previous_node();
                --size_of_list;
                return value;
            }
            else
            {
                throw new Exception("Cannot remove tail. List is empty!");
            }
        }

        public T RemoveElementFromStart(int id)
        {
            var item = head;

            for (var elem = 0; elem < id - 1; ++elem)
            {
                item = item.get_next_node();
            }

            var value = item.get_node_data();
            item.get_previous_node().set_next_node(item.get_next_node());
            item.set_next_node(null);
            --size_of_list;

            return value;
        }

        public T RemoveElementFromBack(int id)
        {
            var item = tail;

            for (var elem = 0; elem < id - 1; ++elem)
            {
                item = item.get_previous_node();
            }

            var value = item.get_node_data();
            item.get_previous_node().set_next_node(item.get_next_node());
            item.set_next_node(null);
            --size_of_list;

            return value;
        }

        public void Sort()
        {
            for (var step_by_each_node = size_of_list - 1; step_by_each_node > 0; --step_by_each_node)
            {
                for (var one_node = 0; one_node < step_by_each_node; ++one_node)
                {

                    if (Convert.ToInt32(list_data[one_node].get_node_data()) > Convert.ToInt32(list_data[one_node + 1].get_node_data()))
                    {
                        T buffer;

                        buffer = list_data[one_node + 1].get_node_data();
                        list_data[one_node + 1].set_node_data(list_data[one_node].get_node_data());
                        list_data[one_node].set_node_data(buffer);
                    }
                }
            }
        }

        public LinkedList<T> Copy()
        {
            LinkedList<T> copyed_list = new LinkedList<T>();

            for (var element = 0; element < size_of_list; ++element)
            {
                copyed_list.PushBack(list_data[element].get_node_data());
            }

            return copyed_list;
        }

        public void Reverse()
        {
            LinkedList<T> buffer_list = new LinkedList<T>();

            buffer_list = this.Copy();

            this.Clear();
            while (!buffer_list.isEmpty())
            {
                this.PushStart(buffer_list.RemoveHead());
            }
        }
    }

    class DoubleNode<T>
    {
        private T node_data;
        private DoubleNode<T> next_node;
        private DoubleNode<T> previous_node;

        public DoubleNode(T value, DoubleNode<T> next_elem, DoubleNode<T> previous_elem)
        {
            node_data = value;
            next_node = next_elem;
            previous_node = previous_elem;
        }

        public T get_node_data()
        {
            return node_data;
        }

        public DoubleNode<T> get_next_node()
        {
            return next_node;
        }

        public DoubleNode<T> get_previous_node()
        {
            return previous_node;
        }

        public void set_node_data(T value)
        {
            node_data = value;
        }

        public void set_next_node(DoubleNode<T> node)
        {
            next_node = node;
        }

        public void set_previous_node(DoubleNode<T> node)
        {
            previous_node = node;
        }
    }
}
