using Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsTests
{
    [TestClass]
    public class ListTest
    {

        //Given When Then
        [TestMethod]
        public void EmptyList_CheckingLength_LengthIsZero()
        {

            List myList = new List();

            Assert.IsTrue(myList.Length == 0);
        }


        [TestMethod]
        public void ListWithOneElement_CheckingLength_LengthIsOne()
        {

            List myList = new List();
            myList.AddToTail(new Node(1, null));
            Assert.IsTrue(myList.Length == 1);
        }

        [TestMethod]
        public void ListWithTwoElement_CheckingLength_LengthIsTwo()
        {
            List myList = new List();
            myList.AddToTail(new Node(1, null));
            myList.AddToTail(new Node(2, null));
            Assert.IsTrue(myList.Length == 2);
        }

        [TestMethod]
        public void ListWithThreeElement_CheckingLength_LengthIsThree()
        {
            List myList = new List();
            myList.AddToTail(new Node(1, null));
            myList.AddToTail(new Node(2, null));
            myList.AddToTail(new Node(3, null));
            Assert.IsTrue(myList.Length == 3);
        }

        [TestMethod]
        public void ListWithOnelement_AddToHead_HeadIsUpdated()
        {
            List myList = new List();
            myList.AddToHead(new Node(1, null));
            myList.AddToHead(new Node(2, null));
            Assert.IsTrue(myList.Head.Data == 2);
        }

        [TestMethod]
        public void ListWithTwolement_AddToHead_HeadIsUpdated()
        {
            List myList = new List();
            myList.AddToHead(new Node(1, null));
            myList.AddToHead(new Node(10, null));
            myList.AddToHead(new Node(99, null));
            Assert.IsTrue(myList.Head.Data == 99);
        }

        [TestMethod]
        public void TwoHeadAdditionTwoTailAddition_ChekingLength_LengthisFour()
        {
            List myList = new List();
            myList.AddToTail(new Node(1, null));
            myList.AddToHead(new Node(2, null));
            myList.AddToTail(new Node(3, null));
            myList.AddToHead(new Node(4, null));
            Assert.AreEqual(4, myList.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EmptyList_RemoveTail_ThrowsException()
        {
            List myList = new List();
            myList.RemoveTail();
        }

        [TestMethod]
        public void OneElementList_RemoveTail_ListIsEmpty()
        {
            List myList = new List();
            myList.AddToTail(new Node(1, null));
            myList.RemoveTail();
            Assert.IsTrue(myList.Head == null);
        }

        [TestMethod]
        public void TwoElementList_RemoveTail_ListWithOneElem()
        {
            List myList = new List();
            myList.AddToTail(new Node(1, null));
            myList.AddToTail(new Node(2, null));
            myList.AddToTail(new Node(3, null));

            myList.RemoveTail();
            Assert.AreEqual(2, myList.Length);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EmptyList_RemoveHead_ThrowsException()
        {
            List myList = new List();
            myList.RemoveHead();
        }

        [TestMethod]
        public void OneElementList_RemoveHead_ListIsEmpty()
        {
            List myList = new List();
            myList.AddToTail(new Node(1, null));
            myList.RemoveHead();
            Assert.IsTrue(myList.Head == null);
        }

        [TestMethod]
        public void TwoElementList_RemoveHead_LengthOne()
        {
            List myList = new List();
            myList.AddToTail(new Node(1, null));
            myList.AddToTail(new Node(2, null));
            myList.RemoveHead();
            Assert.AreEqual(1, myList.Length);
        }

        [TestMethod]
        public void TwoElementList_RemoveHead_LengthTwo()
        {
            List myList = new List();
            myList.AddToTail(new Node(1, null));
            myList.AddToTail(new Node(2, null));
            myList.AddToTail(new Node(2, null));
            myList.RemoveHead();
            Assert.AreEqual(2, myList.Length);
        }
    }
}
