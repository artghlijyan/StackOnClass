using System;

namespace StackDataStructure
{
    public class Stack<T>
    {
        private Node head;

        public int Capacity { get; private set; }
        public int Count { get; set; }

        public Stack()
        {
            head = null;
        }

        public Stack(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException();
            this.Capacity = capacity;

            head = null;
        }

        public void Push(T item)
        {
            Node node = new Node(item);

            if (Count == 0)
            {
                Capacity = 10;
            }
            else
            {
                if (Count > Capacity)
                {
                    throw new Exception("StackOverFlow");
                }

                node.Next = head;
            }

            head = node;
            Count++;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Empty Stack");
            }

            return head.Value;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Empty Stack");
            }

            Node temp = head;
            head = head.Next;
            Count--;

            return temp.Value;
        }

        public void Clear()
        {
            head = null;
            Capacity = Count = 0;
        }

        public bool Contains(T item)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Value.Equals(item))
                    return true;
                temp = temp.Next;
            }
            return false;
        }

        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

            public Node(T value)
            {
                this.Value = value;
            }
        }
    }
}
