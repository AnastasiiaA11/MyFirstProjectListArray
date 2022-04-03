using System;
using System.Collections;
using System.Linq;
using NUnit.Framework;
using System.Text;
using System.Threading.Tasks;
using MyFirstProjectListArray;
using MyFirstProjectListArray.Test.PositiveLinkedTests;
using MyFirstProjectListArray.Test.NegativeLinkedTests;

namespace MyFirstProjectListArray.Test
{
    public class LinkedTest
    {
        [TestCaseSource(typeof(AddTestLinked))]
        public void AddTest(int value, LinkedList list, LinkedList expected)
        {
            list.Add(value);
            LinkedList actual = list;
            
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(AddInStartTestLinked))]
        public void AddInStartTest(int value, LinkedList list, LinkedList expected)
        {
            list.AddInStart(value);
            LinkedList actual = list;

            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(AddIndexTestLinked))]
        public void AddIndexTest(int index,int value, LinkedList list, LinkedList expected)
        {
            list.AddIndex(index,value);
            LinkedList actual = list;

            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(AddIndexNegativeLinkedTest))]
        public void AddIndexTest_WhenIndexLessZeroMoreZero_ShouldThrowIndexOutOfRangeException(int index,int value,LinkedList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.AddIndex(index,value));

        }
        [TestCaseSource(typeof(DeleteLastLinkedTest))]
        public void DeleteLastTest(LinkedList list, LinkedList expected)
        {
            list.DeleteLast();
            LinkedList actual = list;
            
            Assert.AreEqual(expected,actual);
        }

        [TestCaseSource(typeof(DeleteStartTestLinked))]
        public void DeleteStartTest(LinkedList list, LinkedList expected)
        {
            list.DeleteStart();
            LinkedList actual = list;

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(DeleteIndexTestLinked))]
        public void DeleteIndexTest(int index, LinkedList list, LinkedList expected)
        {
            list.DeleteIndex(index);
            LinkedList actual = list;
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(DeleteIndexNegativeLinkedTest))]
        public void DeleteIndexTest_WhenIndexLessZeroMoreZero_ShouldThrowIndexOutOfRangeException(int index, LinkedList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteIndex(index));

        }

        [TestCaseSource(typeof(DeleteNEndTestLinked))]
        public void DeleteNEndTest(int value, LinkedList list, LinkedList expected)
        {
            list.DeleteNEnd(value);
            LinkedList actual = list;
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(DeleteNEndNegativeLinkedTest))]
        public void DeleteNEndTest_WhenIndexLessZeroMoreZero_ShouldThrowException(int value, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteNEnd(value));

        }
        [TestCaseSource(typeof(DeleteNStartTestLinked))]
        public void DeleteNStartTest(int value, LinkedList list, LinkedList expected)
        {
            list.DeleteNStart(value);
            LinkedList actual = list;
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(DeleteNStartNegativeLinkedTest))]
        public void DeleteNStartTest_WhenIndexLessZeroMoreZero_ShouldThrowException(int value, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteNStart(value));

        }
        [TestCaseSource(typeof(DeleteNIndexTestLinked))]
        public void DeleteNIndexTest(int index, int value, LinkedList list, LinkedList expected)
        {
            list.DeleteNIndex(index,value);
            LinkedList actual = list;
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(DeleteNIndexNegativeLinkedTest))]
        public void DeleteNIndexTest_WhenIndexLessZeroMoreZero_ShouldThrowException(int index,int value, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteNIndex(index,value));

        }

        [TestCaseSource(typeof(ShowIndexTestLinked))]
        public void ShowIndexTest(int value, LinkedList list, int expected)
        {
            int actual = list.ShowIndex(value);
            Assert.AreEqual(expected, actual);
        }

    }
}
