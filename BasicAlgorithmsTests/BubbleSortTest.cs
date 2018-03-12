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
        public void ArrayWithDuplicatesElem_Sort_ArrayAscendingSorted()
        {

            int[] actual = new int[] {2, 2, 1};
            int[] expected = new int[] { 1, 2, 2 };
            BubbleSort.Sort(actual);
            CollectionAssert.AreEqual(expected, actual);  
        }

        [TestMethod]
        public void ArraySortedDescending_Sort_ArrayAscendingSorted()
        {

            int[] actual = new int[] { 3, 2, 1};
            int[] expected = new int[] { 1, 2, 3};
            BubbleSort.Sort(actual);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
