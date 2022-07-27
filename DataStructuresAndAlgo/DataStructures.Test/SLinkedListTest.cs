using NUnit.Framework;
using System.Collections.Generic;

namespace DataStructures.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test1()
        {
            List<int> list = new List<int>
            { 1, 2, 3, 4, 5, 6};
            SLinkedList sLinkedList = new SLinkedList();
            var head = sLinkedList.CreateLinkedList(list);
            Assert.True(head != null);
        }
    }
}