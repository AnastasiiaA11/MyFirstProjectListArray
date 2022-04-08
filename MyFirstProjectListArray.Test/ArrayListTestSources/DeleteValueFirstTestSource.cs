using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class DeleteValueFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {2, new ClassListArray(new int[] { 2, 2, 1, 4, 8, 6 }), new ClassListArray(new int[] { 1, 4, 8, 6 }) };
            yield return new object[] { -14, new ClassListArray(new int[] { -22, 2, 1, -14, 11, 6 }), new ClassListArray(new int[] { -22, 2, 1, 11, 6 }) };
            yield return new object[] { 0, new ClassListArray(new int[] { }), new ClassListArray(new int[] {  }) };
            yield return new object[] { 5, new ClassListArray(new int[] { -22, 2, 1, -14, 11, 6 }), new ClassListArray(new int[] { -22, 2, 1, -14, 11, 6 }) };


            yield return new object[] { 2, new LinkedList(new int[] { 2, 2, 1, 4, 8, 6 }), new LinkedList(new int[] {2, 1, 4, 8, 6 }) };
            yield return new object[] { -14, new LinkedList(new int[] { -22, 2, 1, -14, 11, 6 }), new LinkedList(new int[] { -22, 2, 1, 11, 6 }) };
            yield return new object[] { 0, new LinkedList(new int[] { }), new LinkedList(new int[] { }) };
            
        }
    }
}
