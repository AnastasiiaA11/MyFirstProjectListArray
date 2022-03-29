using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class ShowIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 8;
            ClassListArray actuallist = new ClassListArray(new int[] { 2, 8, 1, 4, 8, 6 });
            int expected = 1;

            yield return new object[] { value, actuallist, expected };

            value = 4;
            actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            expected = 3;

            yield return new object[] { value, actuallist, expected };

            value = 10;
            actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            expected = -1;

            yield return new object[] { value, actuallist, expected };
        }
    }
}
