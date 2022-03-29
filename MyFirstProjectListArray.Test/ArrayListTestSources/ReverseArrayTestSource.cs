using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class ReverseArrayTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
           
            ClassListArray actuallist = new ClassListArray(new int[] { 2, 2, 1, 4, 8, 6 });
            ClassListArray expected = new ClassListArray(new int[] { 6,8,4,1,2,2 });

            yield return new object[] { actuallist, expected };


            actuallist = new ClassListArray(new int[] { -22, 2, 1, -14, 8, 6 });
            expected = new ClassListArray(new int[] { 6, 8, -14, 1, 2, -22 });

            yield return new object[] { actuallist, expected };
        }
    }
}
