using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Algo_DS.Test
{
    public class SinglyLinkedListTests
    {
        private SinglyLinkedList<int> _list;

        [SetUp]
        public void Setup()
        {
            _list = new SinglyLinkedList<int>();
        }

        [Test]
        public void CreateEmptyList_CorrectState()
        {
            Assert.IsTrue(_list.IsEmpty);
            Assert.IsTrue(_list.Count == 0);
            Assert.IsNull(_list.Head);
            Assert.IsNull(_list.Tail);
        }

        [Test]
        public void AddFirst_and_AddLast_OneItem_Test()
        {
            _list.AddFirst(1);
            CheckStateWithSingleNode(_list);

            _list.RemoveFirst();
            _list.AddLast(1);

            CheckStateWithSingleNode(_list);
        }
        private void CheckStateWithSingleNode(SinglyLinkedList<int> node)
        {
            Assert.AreSame(node.Head , node.Tail);
            Assert.IsTrue(node.Count == 1);
            Assert.IsFalse(node.IsEmpty);
        }

        [Test]
        public void AddRemoveToGetToStateToSingleNode_Test()
        {
            _list.AddFirst(1);
            _list.AddFirst(2);

            _list.RemoveFirst();
            CheckStateWithSingleNode(_list);

            _list.AddFirst(3);
            _list.RemoveLast();

            CheckStateWithSingleNode(_list);
        }

        [Test]
        public void AddFirst_AndLast_AddItemsInCorrectOrder_Test()
        {
            _list.AddFirst(1);
            _list.AddFirst(2);

            Assert.AreEqual(2, _list.Head.Value);
            Assert.AreEqual(1, _list.Tail.Value);
            
            _list.AddLast(3);
            Assert.AreEqual(3, _list.Tail.Value);

        }

        [Test]
        public void RemoveFirst_EmptyList_throws_Exception()
        {
            Assert.Throws<InvalidOperationException>(() => _list.RemoveFirst());
        }

        [Test]
        public void RemoveLast_EmptyList_throws_Exception()
        {
            Assert.Throws<InvalidOperationException>(() => _list.RemoveLast());
        }
        [Test]
        public void RemoveLast_SingleElement_HeadTailAreNull()
        {
            _list.AddFirst(1);

            _list.RemoveLast();
            
            Assert.AreEqual(0, _list.Count);
            Assert.IsNull(_list.Head);
            Assert.IsNull(_list.Tail);
        }
        [Test]
        public void IterateOver_Items_ExpectedSequence_Test()
        {
            _list.AddLast(1);
            _list.AddLast(2);
            _list.AddLast(3);
            
            var result = new List<int>();

            foreach (var item in _list)
            {
                result.Add(item);
            }
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, result);
        }

        [Test]
        public void RemoveFirst_RemoveLast_CorrectState()
        {
            _list.AddFirst(1);
            _list.AddFirst(2);
            _list.AddFirst(3);
            _list.AddFirst(4);

            _list.RemoveFirst();
            _list.RemoveLast();

            Assert.AreEqual(3, _list.Head.Value);
            Assert.AreEqual(2, _list.Tail.Value);
        }

    }
}
