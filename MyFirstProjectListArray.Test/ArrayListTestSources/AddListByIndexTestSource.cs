using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            ClassListArray actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            ClassListArray actuallistSecond = new ClassListArray(new int[] { 9, 2, 6 });
            ClassListArray expected = new ClassListArray(new int[] { 1,2, 9, 2, 6, 3, 4, 5, 6 });

            yield return new object[] { index,actuallist, actuallistSecond, expected };
        }
    }
}
