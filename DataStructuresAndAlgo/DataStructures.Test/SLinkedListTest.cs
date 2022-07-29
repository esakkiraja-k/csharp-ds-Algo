using NUnit.Framework;
using System.Collections.Generic;

namespace DataStructures.Test
{
    public class SLinkedListTest
    {
        [SetUp]
        public void Setup()
        {
           
        }
        [Test]
        public void TestSLinkedList()
        {
            SLinkedList<string>  sLinkedList = new SLinkedList<string>();
            sLinkedList.Append("1");
            sLinkedList.Append("2");
            sLinkedList.Append("3");
            
           var result = sLinkedList.ToList();
            Assert.AreEqual(3, result.Count);                         
            Assert.AreEqual("1", result[0]);

        }
        [Test]
        public void CreateLinkedListFromListTest()
        {
            List<int> list = new List<int>
            { 1, 2, 3, 4, 5, 6};
            SLinkedList<int> sLinkedList = new SLinkedList<int>();
            var head = sLinkedList.CreateLinkedListFromList(list);
            Assert.True(head != null);
        }

        [Test]
        public void ReverseLinkedListTest()
        {
        var lst = new List<int>() {1,2,3,4,5,6};
            SLinkedList<int> sLinkedList = new SLinkedList<int>();
            foreach (var item in lst)
            {
                sLinkedList.Append(item);
            }
            var reversedsLinkedList = sLinkedList.Reverse(sLinkedList);
            lst.Reverse();
            Assert.AreEqual(lst[0], reversedsLinkedList.ToList()[0]);
        }
    }
}