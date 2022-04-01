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
            int index = 1;
            ClassListArray actuallist = new ClassListArray(new int[] { 1, 2, 3});
            ClassListArray actuallistSecond = new ClassListArray(new int[] { 9, 2, 6,10 });
            ClassListArray expected = new ClassListArray(new int[] { 1, 9, 2, 6, 10,2,3 });

            yield return new object[] { index,actuallist, actuallistSecond, expected };
        }
    }
}
