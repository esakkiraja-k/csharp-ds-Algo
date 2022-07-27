using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Node<T>
    {
        private readonly Node<T> _next;
        private readonly int _value;
        public Node(int value,Node<T> next = null)
        {
            _value = value;
            _next = null;

        }
        public int Value { get; set; }

        public Node<T> Next { get; set; }

    }
    public class SLinkedList
    {
        public Node<int> CreateLinkedList(List<int> list)
        {
            Node<int> head = null;
            foreach (var item in list)
            {
                if (head == null)
                    head = new Node<int>(item);
                else
                {
                    var current_node = head;
                    while (current_node.Next != null)
                    {
                        current_node = current_node.Next;
                    }
                    current_node.Next = new Node<int>(item);

                }                

            }
            return head;
        }
    }
}
