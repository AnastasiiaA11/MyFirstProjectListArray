using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProjectListArray;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{

    internal class AddIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 7;
            int index = 0;
            ClassListArray actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            ClassListArray expected = new ClassListArray(new int[] { 7, 1, 2, 3, 4, 5, 6,});

            yield return new object[] { value, index, actuallist, expected };

            value = -100;
            index = 3;
            actuallist = new ClassListArray(new int[] { 8,4,3,9});
            expected = new ClassListArray(new int[] { 8, 4, 3, -100, 9});

            yield return new object[] { value, index, actuallist, expected };

            value = -100;
            index = 4;
            actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            expected = new ClassListArray(new int[] { 1, 2, 3, 4, -100, 5, 6});

            yield return new object[] { value, index, actuallist, expected };

        }
    }
}
