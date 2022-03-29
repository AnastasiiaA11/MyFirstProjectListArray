using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class SearchIndexMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            ClassListArray actuallist = new ClassListArray(new int[] { 2, 2, 1, 4, 8, 6 });
            int expected = 4;

            yield return new object[] { actuallist, expected };


            actuallist = new ClassListArray(new int[] { -22, 2, 1, -14, 11, 6 });
            expected = 4;

            yield return new object[] { actuallist, expected };

            actuallist = new ClassListArray(new int[] { });
            expected = 0;

            yield return new object[] { actuallist, expected };
        }
    }
}
