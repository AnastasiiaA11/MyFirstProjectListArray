using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class ChangeByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 8;
            int index = 1;
            ClassListArray actuallist = new ClassListArray(new int[] { 2, 2, 1, 4, 8, 6 });
            ClassListArray expected = new ClassListArray(new int[] { 2, 8, 1, 4, 8, 6 });

            yield return new object[] {index,value, actuallist, expected };

            value = 7;
            index = 4;
            actuallist = new ClassListArray(new int[] { 2, 2, 1, 4, 8, 6 });
            expected = new ClassListArray(new int[] { 2, 2, 1, 4, 7, 6 });

            yield return new object[] { index, value, actuallist, expected };

        }
    }
}
