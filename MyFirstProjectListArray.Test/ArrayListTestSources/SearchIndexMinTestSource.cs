using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class SearchIndexMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { new ClassListArray(new int[] { 2, 2, 1, 4, 8, 6 }), 2 };
            yield return new object[] { new ClassListArray(new int[] { 2, -2, 1, 4, 8, 60 }), 1 };


            yield return new object[] { new LinkedList(new int[] { 2, -2, 1, 4, 80, 6 }), 1};
            yield return new object[] { new LinkedList(new int[] { 2, 2, 1, 4, 80, -6 }), 5 };
        }
    }
}
