#nullable disable
using System;

namespace HospitalSystem
{
    public class MyStack<T>
    {
        private Node<T> top;
        public int Count { get; private set; }

        public MyStack()
        {
            top = null;
            Count = 0;
        }

        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            Count++;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack Underflow: The action log is empty.");
            }

            T value = top.Data;
            top = top.Next;
            Count--;
            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}