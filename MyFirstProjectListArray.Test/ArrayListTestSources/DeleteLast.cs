using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    internal class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
                      
            ClassListArray actuallist = new ClassListArray(new int[] { 1, 2, 3, 4, 7, 6 });
            ClassListArray expected = new ClassListArray(new int[] { 1, 2, 3, 4, 7 });

            yield return new object[] {actuallist, expected };


            expected = new ClassListArray(new int[] { 8, 4, 3});
            actuallist = new ClassListArray(new int[] { 8, 4, 3,-9 });
            

            yield return new object[] {actuallist, expected };         
        }
    }
}
