using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class SortArrayByAgeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            ClassListArray actuallist = new ClassListArray(new int[] { 2, 2, 1, 4, 8, 6 });
            ClassListArray expectedList= new ClassListArray(new int[] { 1,2, 2, 4, 6, 8 });

            yield return new object[] { actuallist, expectedList };


            actuallist = new ClassListArray(new int[] { -22, 2, 1, -14, 11, 6 });
            expectedList = new ClassListArray(new int[] { -22,-14,1,2,6,11 });

            yield return new object[] { actuallist, expectedList };

            actuallist = new ClassListArray(new int[] { });
            expectedList = new ClassListArray(new int[] { });

            yield return new object[] { actuallist, expectedList };
        }
    }
}
