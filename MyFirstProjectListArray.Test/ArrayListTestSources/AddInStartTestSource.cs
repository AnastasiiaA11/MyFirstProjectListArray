using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProjectListArray;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class AddInStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 7;
            ClassListArray actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            ClassListArray expected = new ClassListArray(new int[] {7, 1, 2, 3, 4, 5, 6 });

            yield return new object[] { value, actuallist, expected };

            value = -100;
            actuallist = new ClassListArray(new int[] { });
            expected = new ClassListArray(new int[] { -100 });

            yield return new object[] { value, actuallist, expected };

            value = -100;
            actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            expected = new ClassListArray(new int[] { -100,1, 2, 3, 4, 5, 6 });

            yield return new object[] { value, actuallist, expected };

        }
    }
}
