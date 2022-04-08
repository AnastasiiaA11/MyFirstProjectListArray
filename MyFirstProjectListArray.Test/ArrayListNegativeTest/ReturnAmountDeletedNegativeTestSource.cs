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
            

            yield return new object[] { 0,new ClassListArray(new int[] { })};
        }
        
    }
}
