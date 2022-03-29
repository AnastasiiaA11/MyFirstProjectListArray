using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class DeleteIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            ClassListArray actuallist = new ClassListArray(new int[] { 7, 1, 2, 3, 4, 5, 6 });
            ClassListArray expected = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6, });

            yield return new object[] {index, actuallist, expected };

            index = 2;
            actuallist = new ClassListArray(new int[] { 8, 4, 3, -100,9 });
            expected = new ClassListArray(new int[] { 8, 4, -100, 9 });

            yield return new object[] {index, actuallist, expected };

            index = 0;
            actuallist = new ClassListArray(new int[] {8});
            expected = new ClassListArray(new int[] { });

            yield return new object[] { index, actuallist, expected };

        }
    }

}
