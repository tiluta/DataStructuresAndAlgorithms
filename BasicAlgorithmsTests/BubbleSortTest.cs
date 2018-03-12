using System;
using BasicAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicAlgorithmsTests
{
    [TestClass]
    public class BubbleSortTest
    {
        //Given When Then
        [TestMethod]
        public void ArrayAscentingSorted_Sort_ArrayADescendingSorted()
        {

            int[] actual = new int[] {1, 2, 3};
            int[] expected = new int[] {3, 2, 1};
            BubbleSort.Sort(actual, false);
            CollectionAssert.AreEqual(expected, actual);  
        }

        [TestMethod]
        public void ArrayWithDuplicatesElem_Sort_ArrayAscendingSorted()
        {

            int[] actual = new int[] { 3, 4, 3, 4, 3};
            int[] expected = new int[] { 4, 4, 3, 3, 3};
            BubbleSort.Sort(actual, false);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArraySortedAscending_Sort_ArrayDescendingSorted()
        {

            int[] actual = new int[] { 3, 3, 3, 4, 4, 4 };
            int[] expected = new int[] {4, 4, 4, 3, 3, 3};
            BubbleSort.Sort(actual, false);
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ArraySortedDescending_Sort_ArrayAScendingSorted()
        {

            int[] actual = new int[] { 4, 4, 4, 3, 3, 3 }; 
            int[] expected = new int[] { 3, 3, 3, 4, 4, 4 };
            BubbleSort.Sort(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
