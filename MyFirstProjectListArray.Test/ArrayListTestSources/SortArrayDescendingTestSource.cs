using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class SortArrayDescendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            ClassListArray actuallist = new ClassListArray(new int[] { 2, 2, 1, 4, 8, 6 });
            ClassListArray expectedList = new ClassListArray(new int[] { 8,6,4,2,2,1 });

            yield return new object[] { actuallist, expectedList };


            actuallist = new ClassListArray(new int[] { -22, 2, 1, -14, 11, 6 });
            expectedList = new ClassListArray(new int[] { 11,6,2,1,-14,-22 });

            yield return new object[] { actuallist, expectedList };

            actuallist = new ClassListArray(new int[] { });
            expectedList = new ClassListArray(new int[] { });

            yield return new object[] { actuallist, expectedList };
        }
    }
}
