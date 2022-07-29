using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Node<T>
    {
        private  Node<T> _next;
        private  T _value;
        public Node(T value)
        {
            _value = value;
            _next = null;

        }
        public T Value { get { return _value; }  }

        public Node<T> Next { get { return _next; } set { _next = value; } }

    }
    public class SLinkedList<T>
    {
        private Node<T> _head;
        public SLinkedList()
        {
            _head = null;
        }

        public Node<T> Head { get { return _head; } set { _head = value; } }
        public void Append(T value)
        {
            if (_head == null)
            {
                _head = new Node<T>(value);
                return;
            }

            var currentNode = _head;

            while(currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = new Node<T>(value);
            return;
        }
        public List<T> ToList()
        {
           List<T> list = new List<T>();
            Node<T> node = _head;
            while (node != null)
            {
                list.Add(node.Value);
                node = node.Next;
            }
            
            return list;
        }
        public Node<T> CreateLinkedListFromList(List<T> list)
        {
            Node<T> head = null;
            foreach (var item in list)
            {
                if (head == null)
                    head = new Node<T>(item);
                else
                {
                    var current_node = head;
                    while (current_node.Next != null)
                    {
                        current_node = current_node.Next;
                    }
                    current_node.Next = new Node<T>(item);

                }                

            }
            return head;
        }

        public SLinkedList<T> InsertAtHead(SLinkedList<T> linkedList, T value)
        {
            var head = linkedList.Head;
            linkedList.Head = new Node<T>(value);
            linkedList.Head.Next = head;

            return linkedList;
        }

        public SLinkedList<T> Reverse(SLinkedList<T> sLinkedList)
        {
            SLinkedList<T> reversedSLinkedList = new SLinkedList<T> ();
            var node = sLinkedList.Head;
            while (node != null)
            {
                reversedSLinkedList = 
                    reversedSLinkedList.InsertAtHead(reversedSLinkedList, node.Value);
                node = node.Next;
            }
            
            return reversedSLinkedList;
        }
    }
}
