using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class AddListLastTestSource: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            
            ClassListArray actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6 });
            ClassListArray actuallistSecnd= new ClassListArray(new int[] { 9,2,6 });
            ClassListArray expected = new ClassListArray(new int[] { 1, 2, 3, 4, 5, 6, 9,2,6 });

            yield return new object[] { actuallist, actuallistSecnd, expected };                 
        }
    }
}
