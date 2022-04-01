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
    }
}
