using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class ReturnRecoveryTestSource: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ClassListArray actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            int expected  = 6;

            yield return new object[] {actuallist, expected };

           actuallist = new ClassListArray(new int[] { });
           expected = 0;

            yield return new object[] { actuallist, expected };


        }
    }
}
