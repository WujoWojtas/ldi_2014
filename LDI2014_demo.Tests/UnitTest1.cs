using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LDI2014_demo.Logic;

namespace LDI2014_demo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldSortAlreadySortedList()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            ISortingAlgorithm algo = new QuickSortAlgorithm();

            algo.Sort(numbers);

            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4, 5 }, numbers);
        }

        [TestMethod]
        public void ShouldSortList()
        {
            List<int> numbers = new List<int>() { 5, 2, 3, 4, 1 };
            ISortingAlgorithm algo = new QuickSortAlgorithm();

            algo.Sort(numbers);

            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4, 5 }, numbers);
        }

        [TestMethod]
        public void ShouldSortList2()
        {
            List<int> numbers = new List<int>() { 5, 7, 8, 1, 4, 0, 4, 6, 8, 2, 1, 5, 2, 6, 9 };
            ISortingAlgorithm algo = new QuickSortAlgorithm();

            algo.Sort(numbers);

            CollectionAssert.AreEqual(new List<int>() { 0, 1, 1, 2, 2, 4, 4, 5, 5, 6, 6, 7, 8, 8, 9 }, numbers);
        }

        [TestMethod]
        public void ShouldSortList3()
        {
            List<int> numbers = new List<int>() { 5, 5, 5, 5, 5, 5, 5 };
            ISortingAlgorithm algo = new QuickSortAlgorithm();

            algo.Sort(numbers);

            CollectionAssert.AreEqual(new List<int>() { 5, 5, 5, 5, 5, 5, 5 }, numbers);
        }
        [TestMethod]
        public void ShouldSortList4()
        {
            List<int> numbers = new List<int>() { 1 };
            ISortingAlgorithm algo = new QuickSortAlgorithm();

            algo.Sort(numbers);

            CollectionAssert.AreEqual(new List<int>() { 1 }, numbers);
        }
        [TestMethod]
        public void ShouldSortList5()
        {
            List<int> numbers = new List<int>() { 7, 2, 4, 7, 3, 1 };
            ISortingAlgorithm algo = new QuickSortAlgorithm();

            algo.Sort(numbers);

            CollectionAssert.AreEqual(new List<int>() { 1, 2, 3, 4, 7, 7 }, numbers);
        }
    }
}
