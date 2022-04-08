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
           
            yield return new object[] { 2, new ClassListArray(new int[] { 2, 2, 1, 4, 2, 6 }),3 };
            yield return new object[] { 4, new ClassListArray(new int[] { 2, 15, 4, 4, 2, 9 }), 2 };
            yield return new object[] { 2, new ClassListArray(new int[] { 2, 2, 1, 4, 2, 6 }), 3 };
            yield return new object[] { -8, new ClassListArray(new int[] { 2, 15, 4, 4, 2, -8 }), 1 };

            yield return new object[] { 2, new LinkedList(new int[] { 2, 2, 1, 4, 2, 6 }), 3 };
            yield return new object[] { 4, new LinkedList(new int[] { 2, 15, 4, 4, 2, 9 }), 2 };
            yield return new object[] { 2, new LinkedList(new int[] { 2, 2, 1, 4, 2, 6 }), 3 };
            yield return new object[] { -8, new LinkedList(new int[] { 2, 15, 4, 4, 2, -8 }), 1 };
            yield return new object[] { 1, new LinkedList(new int[] { 6,9,1,2,1 }), 2 };
           



        }
    }
}
