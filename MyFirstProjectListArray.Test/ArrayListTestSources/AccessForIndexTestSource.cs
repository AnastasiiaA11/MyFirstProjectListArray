using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    public class AccessForIndexTestSource: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            ClassListArray actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            int expected = 1;

            yield return new object[] { index, actuallist, expected };

            index = 3;
            actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            expected = 4;

            yield return new object[] { index, actuallist, expected };
        }
    }
}
