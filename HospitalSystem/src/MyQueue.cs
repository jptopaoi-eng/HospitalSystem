using System;

namespace HospitalSystem.src
{
    public class MyQueue<T>
    {
        // Private internal node links to maintain encapsulation
        private Node<T> front;
        private Node<T> rear;

        // Public property to track the number of items
        public int Count { get; private set; }

        public MyQueue()
        {
            front = null;
            rear = null;
            Count = 0;
        }

        // Checks if the queue is empty
        public bool IsEmpty()
        {
            return front == null;
        }

        // Enqueue: Adds an item to the rear of the queue (FIFO)
        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (IsEmpty())
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
            Count++;
        }

        // Dequeue: Removes and returns the item from the front of the queue
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue Underflow: The outpatient line is empty.");
            }

            T value = front.Data;
            front = front.Next;

            // If front becomes null, rear must also be null (queue is empty)
            if (front == null)
            {
                rear = null;
            }

            Count--;
            return value;
        }

        // Peek: Views the item at the front without removing it
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty: No patients in line to peek.");
            }

            return front.Data;
        }
    }
}
