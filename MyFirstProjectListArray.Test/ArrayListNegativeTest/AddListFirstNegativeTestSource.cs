using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListNegativeTestSources
{
    internal class AddListFirstNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ClassListArray actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            ClassListArray actuallistSecnd = null;

            yield return new object[] { actuallist, actuallistSecnd };

        }
    }
}
