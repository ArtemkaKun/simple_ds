using System;
using System.Collections.Generic;

namespace simple_ds.Structures
{
    class LinkedList <T>
    {
        private int size_of_list;
        private readonly List<Node<T>> list_data;
        private Node<T> head;
        private Node<T> tail;

        public LinkedList()
        {
            size_of_list = 0;
            list_data = new List<Node<T>>();
            head = null;
        }

        public T RemoveHead()
        {
            var value = head.Data();
            head = head.getNext();
            return value;
        }

        public T GetElement(int id)
        {
            var item = head;
            for (var elem = 0; elem < id; ++elem)
            {
                item = item.getNext();
            }

            return item.Data();
        }

        public void PushBack(T item)
        {
            ++size_of_list;
            if (head == null)
            {
                list_data.Add(new Node<T>(item, null));
                head = list_data[0];
                tail = list_data[0];
            }
            else
            {
                list_data.Add(new Node<T>(item, null));
                tail.setNext(list_data[size_of_list - 1]);
                tail = list_data[size_of_list - 1];
            }
        }

        public void PushStart(T item)
        {
            ++size_of_list;
            list_data.Add(new Node<T>(item, head));
            head = list_data[size_of_list - 1];
        }

        public bool isEmpty()
        {
            if (size_of_list == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Size()
        {
            return size_of_list;
        }

        public void Clear()
        {
            size_of_list = 0;
            list_data.Clear();
            head = null;
            tail = null;
        }

        //this method return head element
        public Node<T> Head()
        {
            return head;
        }

        public void Sort()
        {
            for (var step_by_each_node = size_of_list - 1; step_by_each_node > 0; --step_by_each_node)
            {
                for (var one_node = 0; one_node < step_by_each_node; ++one_node)
                {

                    if (Convert.ToInt32(list_data[one_node].Data()) > Convert.ToInt32(list_data[one_node + 1].Data()))
                    {
                        T buffer;

                        buffer = list_data[one_node + 1].Data();
                        list_data[one_node + 1].setData(list_data[one_node].Data());
                        list_data[one_node].setData(buffer);
                    }
                }
            }
        }

        public LinkedList<T> Copy()
        {
            LinkedList<T> copyed_list = new LinkedList<T>();

            for (var element = 0; element < size_of_list; ++element)
            {
                copyed_list.PushBack(list_data[element].Data());
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
                this.PushBack(buffer_list.Pop());
            }
        }
    }

    class Node <T>
    {
        private T node_data;
        private Node<T> next_node;

        public Node(T value, Node<T> next_elem)
        {
            node_data = value;
            next_node = next_elem;
        }

        public void setNext(Node<T> next_elem)
        {
            next_node = next_elem;
        }

        public Node<T> getNext()
        {
            return next_node;
        }

        public T Data()
        {
            return node_data;
        }

        public void setData(T value)
        {
            node_data = value;
        }
    }
}
