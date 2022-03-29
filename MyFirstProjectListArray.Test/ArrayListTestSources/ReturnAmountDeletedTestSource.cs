using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class ReturnAmountDeletedTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 2;
            ClassListArray actuallist = new ClassListArray(new int[] { 2, 2, 1, 4, 2, 6 });
            int expected = 3;

            yield return new object[] { value, actuallist, expected};

            value = -22;
            actuallist = new ClassListArray(new int[] { -22, 2, 1, -22, 11, 6 });
            expected = 2;

            yield return new object[] { value, actuallist, expected};

           

        }
    }
}
