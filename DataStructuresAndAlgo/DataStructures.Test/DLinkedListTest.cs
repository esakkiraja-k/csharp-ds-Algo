using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace DataStructures.Test
{
    public class DLinkedListTest
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void TestDLinkedList()
        {
            DLinkedList<string> dLinkedList = new DLinkedList<string>();
            dLinkedList.Append("1");
            dLinkedList.Append("2");
            dLinkedList.Append("3");

            
            //head test
            DoubleNode<string> result = dLinkedList.Head;
            List<string> list = new List<string>();
            while (result != null)
            {
                list.Add(result.Value);
                result = result.Next;
            }
            Assert.AreEqual(3, list.Count);
            Assert.AreEqual("1", list[0]);
            Assert.AreEqual("2", list[1]);
            Assert.AreEqual("3", list[2]);

            //tail test
            DoubleNode<string> tailResult = dLinkedList.Tail;
            List<string> tailList = new List<string>();
            while (tailResult != null)
            {
                tailList.Add(tailResult.Value);
                tailResult = tailResult.Previous;
            }
            Assert.AreEqual(3, tailList.Count);
            Assert.AreEqual("3", tailList[0]);
            Assert.AreEqual("2", tailList[1]);
            Assert.AreEqual("1", tailList[2]);
            
            

        }
    }
}
