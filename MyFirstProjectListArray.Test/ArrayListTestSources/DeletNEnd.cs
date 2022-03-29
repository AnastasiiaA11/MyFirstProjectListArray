using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{

    internal class DeleteNEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 2;
           
            ClassListArray actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            ClassListArray expected = new ClassListArray(new int[] { 1, 2, 3, 4});

            yield return new object[] { value,actuallist, expected };

           value = 4;

            actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            expected = new ClassListArray(new int[] { 1, 2});

            yield return new object[] { value, actuallist, expected };

        }
    }
}
