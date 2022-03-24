using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstProjectListArray;

namespace MyFirstProjectListArray.Test.ArrayListNegativeTestSources
{
    internal class AddIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {           
            int value = 7;
            int index = -2;
            ClassListArray actuallist = new ClassListArray(new int[] {15,4,8,1 });

            yield return new object[] { value, index, actuallist};
        }
    }
}
