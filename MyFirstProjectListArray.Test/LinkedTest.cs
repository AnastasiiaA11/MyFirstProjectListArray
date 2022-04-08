using System;
using MyFirstProjectListArray.Test.ArrayListNegativeTestSources;
using MyFirstProjectListArray.Test.ArrayListTestSources;
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

        [TestCaseSource(typeof(ChangeByIndexTestLinked))]
        public void ChangeByIndexTest(int index,int value, LinkedList list, LinkedList expected)
        {
            list.ChangeByIndex(index, value);
            LinkedList actual = list;
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(ChangeByIndexNegativeLinkedTest))]
        public void ChangeByIndexTest_WhenIndexLessZeroMoreZero_ShouldThrowException(int index, int value, LinkedList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.ChangeByIndex(index, value));

        }
        [TestCaseSource(typeof(ReverseArrayTestLinked))]
        public void ReverseArrayTest(LinkedList list, LinkedList expected)
        {
            list.ReverseArray();
            LinkedList actual = list;
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(SearchMaxTestLinked))]
        public void SearchMaxTest(LinkedList list, int expected)
        {
            int actual = list.SearchMax();
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(SearchMaxNegativeLinkedTest))]
        public void SearchMaxTest_WhenLenghtZero_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.SearchMax());

        }
        [TestCaseSource(typeof(SearchMinTestLinked))]
        public void SearchMinTest(LinkedList list, int expected)
        {
            int actual = list.SearchMin();
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(SearchMinNegativeLinkedTest))]
        public void SearchMinTest_WhenLenghtZero_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.SearchMin());

        }

        [TestCaseSource(typeof(SearchMinTestSource))]
        public void SearchMinTest(IMyList list, int expected)
        {
            int actual = list.SearchMin();
            Assert.AreEqual(expected, actual);

        }

        [TestCaseSource(typeof(SearchIndexMaxTestSource))]
        public void SearchIndexMaxTest(IMyList list, int expected)
        {
            int actual = list.SearchIndexMax();
            Assert.AreEqual(expected, actual);

        }
        [TestCaseSource(typeof(SearchIndexMinTestSource))]
        public void SearchIndexMinTest(IMyList list, int expected)
        {
            int actual = list.SearchIndexMin();
            Assert.AreEqual(expected, actual);

        }


        [TestCaseSource(typeof(DeleteValueFirstTestSource))]
        public void DeleteValueFirstTest(int value,IMyList list, IMyList expected)
        {
            IMyList actual = list;
            list.DeleteValueFirst(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCaseSource(typeof(ReturnAmountDeletedTestSource))]
        public void ReturnAmountDeletedTest(int value, IMyList list, int expected)
        {
            int actual = list.ReturnAmountDeleted(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ReturnAmountDeletedNegativeTestSource))]
        public void ReturnAmountDeletedNegativeTest_WhenLeghtzero_ShouldThrowIndexOutOfRangeException(int value, IMyList list)
        {
            Assert.Throws<Exception>(() => list.ReturnAmountDeleted(value));
        }

        [TestCaseSource(typeof(AddListLastTestLinked))]
        public void AddListLastTest(LinkedList list, LinkedList extraList, LinkedList expectedList)
        {
            list.AddListLast(extraList);
            LinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListFirstTestLinked))]
        public void AddListFirstTest(LinkedList list, LinkedList extraList, LinkedList expectedList)
        {
            list.AddListFirst(extraList);
            LinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListByIndexTestLinked))]
        public void AddListByIndexTest(int index,LinkedList list, LinkedList extraList, LinkedList expectedList)
        {
            list.AddListByIndex(extraList,index);
            LinkedList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
    }
}
