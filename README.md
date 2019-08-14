# simple_ds
My implementation of basement data structures in C#

Hello, my name is Artem. I decide to create my own implementataion of data staructures which I use everyday in my programming projects.
List of data structures in this project:
1) Stack
2) Queue
3) Linked list
4) Double linked list (TODO)
5) Double queue (TODO)
6) Graphs (TODO)
7) Trees (TODO)
8) Prefix trees (TODO)
9) Hash tables (TODO)

Stack

For stack I used List type from System.Collections.Generic.
What Stack class can do?
1) int Size() - return size of a stack
2) bool isEmpty() - check if stack is empty
3) T Peek() - return top element of a stack without remowing it
4) void Push(T new_item) - add new item on top of a stack (NOTE: top of a stack it is actually last element of a list)
5) T Pop() - return top element of a stack and remowe it
6) Stack<T> Reverse() - return stack with reversed elements order in a stack (turn a stack into a queue)
7) Stack<T> Copy() - return a deep copy of a stack
8) void Sort() - sort values in this stack (bubble sort) TODO(another alghorithm of sorting)!

Queue

For queue I used List type from System.Collections.Generic.
What Queue class can do?
1) int Size() - return size of a queue
2) bool isEmpty() - check if queue is empty
3) T Top() - return top element of a queue without remowing it
4) void Enqueue(T new_item) - add new item on the end of a queue
5) T Dequeue() - return top element of a queue and remowe it
6) void Reverse() - reverse elements order in a queue
7) void Reverse(int n) - reverse first n-elements in a queue
8) Queue<T> Copy() - return a deep copy of a queue
9) void Sort() - sort values in this queue (bubble sort) TODO(another alghorithm of sorting)!
10) void Clear() - clear a queue

LinkedList

For linked list I used List type from System.Collections.Generic.
What LinkedList class can do?
1) int Size() - return size of a linked list 
2) bool isEmpty() - check if linked list is empty
3) T PeakHead() - return head element of a linked list without remowing it
4) T GetElement(int n) - return n-element of a linked list without remowing it
5) void PushBack(T item) - add new item on the end of a linked list
6) void PushStart(T item) - add new item on the end of a linked list (but move head pointer on it)
7) T RemoveHead() - return value of a head element of a linked list and remowe it
8) T RemoveElement(int n) - return value of a n-element of a linked list and remowe it
9) void Reverse() - reverse elements order in a linked list
10) LinkedList<T> Copy() - return a deep copy of a linked list
11) void Sort() - sort values in this linked (bubble sort) TODO(another alghorithm of sorting)!
12) void Clear() - clear a linked list
