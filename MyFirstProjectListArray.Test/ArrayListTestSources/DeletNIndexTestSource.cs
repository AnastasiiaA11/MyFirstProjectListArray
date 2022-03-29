using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class DeleteNIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            int value = 3;
            ClassListArray actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            ClassListArray expected = new ClassListArray(new int[] { 1, 2, 6 });

            yield return new object[] { index,value, actuallist, expected };

            index = 4;
            value = 2;
            actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            expected = new ClassListArray(new int[] { 1, 2, 3,4 });

            yield return new object[] { index, value, actuallist, expected };
        }
    }
}
