# simple_ds
My implementation of basement data structures in C#

Hello, my name is Artem. I decide to create my own implementataion of data staructures which I use everyday in my programming projects.
List of data structures in this project:
1) Stack
2) Queue (TODO)
3) Double queue (TODO)
4) Linked lists (TODO)
5) Graphs (TODO)
6) Trees (TODO)
7) Prefix trees (TODO)
8) Hash tables (TODO)

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