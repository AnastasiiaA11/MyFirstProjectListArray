using NUnit.Framework;
using System.Collections;
using System;
using MyFirstProjectListArray.Test.ArrayListTestSources;
using MyFirstProjectListArray.Test.ArrayListNegativeTestSources;


namespace MyFirstProjectListArray.Test
{
    public class Tests
    {
        [TestCaseSource(typeof(AddTestSource))]
        public void AddTest(int value, ClassListArray list, ClassListArray expectedList)
        {
            ClassListArray actualList = list;
            actualList.Add(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddInStartTestSource))]
        public void AddInStartTest(int value, ClassListArray list, ClassListArray expectedList)
        {
            ClassListArray actualList = list;
            actualList.AddInStart(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddIndexTestSource))]
        public void AddIndexTest(int value, int index, ClassListArray list, ClassListArray expectedList)
        {
            ClassListArray actualList = list;
            actualList.AddIndex(index,value);
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(AddIndexNegativeTestSource))]
        public void AddIndexNegativeTest_WhenIndexOutOfRangeOfList_ShouldThrowIndexOutOfRangeException(int value, int index, ClassListArray list)
        {
            
            Assert.Throws<IndexOutOfRangeException>(() => list.AddIndex(index,value));
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(ClassListArray list, ClassListArray expectedList)
        {
            ClassListArray actualList = list;
            actualList.DeleteLast();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteLastNegativeTestSource))]
        public void DeleteLastTest_WhenLeghtzero_ShouldThrowIndexOutOfRangeException(ClassListArray list)
        {
            Assert.Throws<NotImplementedException>(() => list.DeleteLast());

        }

        [TestCaseSource(typeof(DeleteStartTestSource))]
        public void DeleteStartTest(ClassListArray list, ClassListArray expectedList)
        {
            ClassListArray actualList = list;
            actualList.DeleteStart();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteStartNegativeTestSource))]
        public void DeleteStartTest_WhenLeghtzero_ShouldThrowIndexOutOfRangeException(ClassListArray list)
        {
            Assert.Throws<NotImplementedException>(() => list.DeleteStart());

        }

        [TestCaseSource(typeof(DeleteIndexTestSource))]
        public void DeleteIndexTest(int index,ClassListArray list, ClassListArray expectedList)
        {
           
            ClassListArray actualList = list;
            list.DeleteIndex(index);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteIndexNegativeTestSource))]
        public void DeleteIndexTest_WhenLeghtzero_ShouldThrowIndexOutOfRangeException(int index,ClassListArray list)
        {
            Assert.Throws<Exception>(() => list.DeleteIndex(index));           
        }
        [TestCaseSource(typeof(DeleteIndexNegativeTestSource_WhenIndexOutOfRange))]
        public void DeleteIndexTest_WhenIndexOutOfRange_ShouldThrowIndexOutOfRangeException(int index, ClassListArray list)
        {          
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteIndex(index));

        }


        [TestCaseSource(typeof(DeleteNEndTestSource))]
        public void DeleteNEndTest(int value, ClassListArray list, ClassListArray expectedList)
        {
            ClassListArray actualList = list;
            actualList.DeleteNEnd(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteNEndNegativeTestSource))]
        public void DeleteNEndTest_WhenLeghtzero_ShouldThrowIndexOutOfRangeException(int value,ClassListArray list)
        {
            Assert.Throws<Exception>(() => list.DeleteNEnd(value));

        }
        [TestCaseSource(typeof(DeleteNEndNegativeTestSource_ArgumentOutOfRangeException))]
        public void DeleteNEndTest_WhenValueLessorMoreZero_ShouldThrowIndexOutOfRangeException(int value, ClassListArray list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteNEnd(value));

        }

        [TestCaseSource(typeof(DeleteNStartTestSource))]
        public void DeletNStartTest(int value, ClassListArray list, ClassListArray expectedList)
        {
            ClassListArray actualList = list;
            actualList.DeleteNStart(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteNStartNegativeTestSource))]
        public void DeletNStartTest_WhenLeghtzero_ShouldThrowIndexOutOfRangeException(int value, ClassListArray list)
        {
            Assert.Throws<Exception>(() => list.DeleteNStart(value));

        }
        [TestCaseSource(typeof(DeleteNStartNegativeTestSource_ArgumentOutOfRangeException))]
        public void DeletNStartTest_WhenValueLessorMoreZero_ShouldThrowIndexOutOfRangeException(int value, ClassListArray list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteNStart(value));

        }

        [TestCaseSource(typeof(DeleteNIndexTestSource))]
        public void DeletNIndexTest(int index, int value, ClassListArray list, ClassListArray expectedList)
        {
            ClassListArray actualList = list;
            actualList.DeleteNIndex(index,value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteNIndexNegativeTestSource))]
        public void DeletNIndexTest_WhenLeghtzero_ShouldThrowIndexOutOfRangeException(int index,int value, ClassListArray list)
        {
            Assert.Throws<Exception>(() => list.DeleteNIndex(index,value));

        }

        [TestCaseSource(typeof(DeleteNIndexNegativeTestSource_ArgumentOutOfRangeException))]
        public void DeletNIndexTest_WhenValueLessorMoreZero_ShouldThrowIndexOutOfRangeException(int index, int value, ClassListArray list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteNIndex(index, value));

        }

        [TestCaseSource(typeof(ReturnRecoveryTestSource))]
        public void ReturnRecoveryTest(ClassListArray list, int expected)
        {
            ClassListArray actualList = list;
            int actual=list.ReturnRecovery();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(AccessForIndexTestSource))]
        public void AccessForIndexTest(int index, ClassListArray list, int expected)
        {
          
            int actual = list.AccessForIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ShowIndexTestSource))]
        public void ShowIndexTest(int value, ClassListArray list, int expected)
        {
            int actual = list.ShowIndex(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ChangeByIndexTestSource))]
        public void ChangeByIndexTest(int index,int value, ClassListArray list, ClassListArray expectedList)
        {
            ClassListArray actualList = list;
            actualList.ChangeByIndex(index, value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ChangeByIndexNegativeTestSource))]
        public void ChangeByIndexTest_WhenLeghtzero_ShouldThrowIndexOutOfRangeException(int index, int value, ClassListArray list)
        {
            Assert.Throws<Exception>(() => list.ChangeByIndex(index, value));

        }
        [TestCaseSource(typeof(ChangeByIndexNegativeTestSource_IndexOutOfRangeException))]
        public void ChangeByIndexTest_WhenValueLessorMoreZero_ShouldThrowIndexOutOfRangeException(int index, int value, ClassListArray list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.ChangeByIndex(index, value));

        }

        [TestCaseSource(typeof(ReverseArrayTestSource))]
        public void ReverseArrayTest(ClassListArray list, ClassListArray expectedList)
        {
            ClassListArray actualList = list;
            actualList.ReverseArray();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(SearchMaxTestSource))]
        public void SearchMaxTest(ClassListArray list, int expected)
        {
            int actual = list.SearchMax();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(SearchMinTestSource))]
        public void SearchMinTest(ClassListArray list, int expected)
        {
            int actual = list.SearchMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(SearchIndexMaxTestSource))]
        public void SearchIndexMaxTest(ClassListArray list, int expected)
        {
            int actual = list.SearchIndexMax();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(SearchIndexMinTestSource))]
        public void SearchIndexMinTest(ClassListArray list, int expected)
        {
            int actual = list.SearchIndexMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(SortArrayByAgeTestSource))]
        public void SortArrayByAgeTest(ClassListArray list, ClassListArray expectedList)
        {
            ClassListArray actualList = list;
            actualList.SortArrayByAge();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(SortArrayDescendingTestSource))]
        public void SortArrayDescendingTest(ClassListArray list, ClassListArray expectedList)
        {
            ClassListArray actualList = list;
            actualList.SortArrayDescending();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteValueFirstTestSource))]
        public void DeleteValueFirstTest(int value,ClassListArray list, ClassListArray expectedList)
        {
            ClassListArray actualList = list;
            actualList.DeleteValueFirst(value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ReturnAmountDeletedTestSource))]
        public void ReturnAmountDeletedTest(int value, ClassListArray list, int expected)
        {
            int actual = list.ReturnAmountDeleted(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ReturnAmountDeletedNegativeTestSource))]
        public void ReturnAmountDeletedNegativeTest_WhenLeghtzero_ShouldThrowIndexOutOfRangeException(int value, ClassListArray list)
        {
            Assert.Throws<Exception>(() => list.ReturnAmountDeleted(value));
        }

        [TestCaseSource(typeof(AddListLastTestSource))]
        public void AddListLastTest(ClassListArray actualList, ClassListArray list,ClassListArray expectedList)
        {
           
            actualList.AddListLast(list);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListLastNegativeTestSource))]
        public void AddListLastNegativeTest_WhenLeghtNull_ShouldThrowIndexOutOfRangeException(ClassListArray actualList,ClassListArray list)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListLast(list));
        }

        [TestCaseSource(typeof(AddListFirstTestSource))]
        public void AddListFirstTest(ClassListArray actualList, ClassListArray list, ClassListArray expectedList)
        {

            actualList.AddListFirst(list);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListFirstNegativeTestSource))]
        public void AddListFirstNegativeTest_WhenLeghtNull_ShouldThrowIndexOutOfRangeException(ClassListArray actualList, ClassListArray list)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListFirst(list));
        }

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndexTest(int index,ClassListArray actualList, ClassListArray list,ClassListArray expectedList)
        {
           
            actualList.AddListByIndex(list,index);
            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(AddListByIndexNegativeTestSource))]
        public void AddListByIndexNegativeTest_WhenLeghtNull_ShouldThrowIndexOutOfRangeException(int index, ClassListArray actualList, ClassListArray list)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListByIndex(list, index));
        }
    }
}