using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class DeleteStartTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            
            ClassListArray actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 7, 6 });
            ClassListArray expected = new ClassListArray(new int[] { 2, 3, 4, 7,6 });

            yield return new object[] { actuallist, expected };

            actuallist = new ClassListArray(new int[] { 0, 8, 2, 3, 4 });
            expected = new ClassListArray(new int[] { 8, 2, 3,4 });
            


            yield return new object[] {actuallist, expected };
        }
    }
}
