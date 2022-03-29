using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListNegativeTestSources
{
    internal class DeleteLastNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            
            ClassListArray actuallist = new ClassListArray(new int[] { });

            yield return new object[] {actuallist };
        }
    }
}
