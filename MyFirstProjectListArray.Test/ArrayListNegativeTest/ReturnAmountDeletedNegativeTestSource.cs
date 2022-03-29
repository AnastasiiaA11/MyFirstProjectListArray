using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListNegativeTestSources
{
    internal class ReturnAmountDeletedNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 0;
            ClassListArray actuallist = new ClassListArray(new int[] { });

            yield return new object[] { value,actuallist };
        }
    }
}
