using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class SortArrayDescendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {


            yield return new object[] { new ClassListArray(new int[] { 2, 2, 1, 4, 8, 6 }), new ClassListArray(new int[] { 8,6,4,2,2,1}) };
            yield return new object[] { new ClassListArray(new int[] { 2, -2, 1, 4, 8, 60 }), new ClassListArray(new int[] { 60,8,4,2,1,-2 }) };


            yield return new object[] { new LinkedList(new int[] { 2, -2, 1, 4, 80, 6 }), new LinkedList(new int[] { 80,6,4,2,1,-2 }) };
            yield return new object[] { new LinkedList(new int[] { 2, 2, 1, 4, 80, -6 }), new LinkedList(new int[] { 80,4,2,2,1,-6 }) };
        }
    }
}
