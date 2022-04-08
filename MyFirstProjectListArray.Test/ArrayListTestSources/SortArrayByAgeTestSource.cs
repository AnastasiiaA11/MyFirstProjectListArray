using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class SortArrayByAgeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { new ClassListArray(new int[] { 2, 2, 1, 4, 8, 6 }), new ClassListArray(new int[] { 1,2,2,4,6,8 } )};
            yield return new object[] { new ClassListArray(new int[] { 2, -2, 1, 4, 8, 60 }), new ClassListArray(new int[] { -2,1,2,4,8,60 }) };


            yield return new object[] { new LinkedList(new int[] { 2, -2, 1, 4, 80, 6 }), new LinkedList(new int[] { -2,1,2,4,6,80}) };
            yield return new object[] { new LinkedList(new int[] { 2, 2, 1, 4, 80, -6 }), new LinkedList(new int[] { -6,1,2,2,4,80 }) };
        }
    }
}
