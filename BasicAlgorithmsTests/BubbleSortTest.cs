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
        public void ArrayWithDuplicatesElem_Sort_ArrayAscendingSort()
        {

            int[] unsortedList = new int[] {2, 2, 1};
            int[] sortedList = new int[] { 1, 2, 2 };
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(unsortedList);
            CollectionAssert.AreEqual(unsortedList, sortedList);  
        }

        [TestMethod]
        public void ArrayWithNoElemDuplicates_Sort_ArrayAscendingSort()
        {

            int[] unsortedList = new int[] { 3, 2, 1};
            int[] sortedList = new int[] { 1, 2, 3};
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(unsortedList);
            CollectionAssert.AreEqual(unsortedList, sortedList);
        }
    }
}
