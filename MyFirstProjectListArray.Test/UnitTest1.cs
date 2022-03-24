using NUnit.Framework;
using System.Collections;
using System;
using MyFirstProjectListArray.Test.ArrayListTestSources;
using MyFirstProjectListArray.Test.ArrayListNegativeTestSources;
using MyFirstProjectListArray;


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
    }
}