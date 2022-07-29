using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class DoubleNode<T>
    {
        private T _value;
        private DoubleNode<T> _next;
        private DoubleNode<T> _previous;
        public DoubleNode(T value)
        {
            _value = value;
            _previous = null;
            _next = null;    
        }
        public T Value { get { return _value; } }
        public DoubleNode<T> Previous { get { return _previous; } set { _previous = value; } }

        public DoubleNode<T> Next { get { return _next; } set { _next = value; } }

    }
    public class DLinkedList<T>
    {
        private DoubleNode<T> _head;
        private DoubleNode<T> _tail;
        public DLinkedList()
        {
            _head = null;
            _tail = null;
        }
        public DoubleNode<T> Head { get { return _head; } }

        public DoubleNode<T> Tail { get { return _tail; } }
        public void Append(T value)
        {
            if(_head == null)
            {
                _head = new DoubleNode<T>(value);
                _tail = _head;
            }
            else
            {
                _tail.Next = new DoubleNode<T>(value);
                _tail.Next.Previous = _tail;
                _tail = _tail.Next;
            }
            return;

        }

    }
}
