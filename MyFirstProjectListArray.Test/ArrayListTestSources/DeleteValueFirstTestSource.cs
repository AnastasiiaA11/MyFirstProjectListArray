using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class DeleteValueFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 2;
            ClassListArray actuallist = new ClassListArray(new int[] { 2, 2, 1, 4, 8, 6 });
            ClassListArray expectedList = new ClassListArray(new int[] { 1, 4, 8, 6 });

            yield return new object[] { value,actuallist, expectedList };

            value = -14;
            actuallist = new ClassListArray(new int[] { -22, 2, 1, -14, 11, 6 });
            expectedList = new ClassListArray(new int[] { -22, 2, 1,11, 6 });

            yield return new object[] { value,actuallist, expectedList };

            value = 0;
            actuallist = new ClassListArray(new int[] { });
            expectedList = new ClassListArray(new int[] { });

            yield return new object[] { value,actuallist, expectedList };

            value = 5;
            actuallist = new ClassListArray(new int[] { -22, 2, 1, -14, 11, 6 });
            expectedList = new ClassListArray(new int[] { -22, 2, 1, -14, 11, 6 });

            yield return new object[] { value, actuallist, expectedList };
        }
    }
}
