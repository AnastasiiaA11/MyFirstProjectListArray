using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListTestSources
{
    public class SearchIndexMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ClassListArray(new int[] { 2, 2, 1, 4, 8, 6 }), 4};
            yield return new object[] { new ClassListArray(new int[] { 2, -2, 1, 4, 8, 60 }), 5 };


            yield return new object[] { new LinkedList(new int[] { 2, -2, 1, 4, 80, 6 }), 4 };
            yield return new object[] { new LinkedList(new int[] { 2, -2, 1, 4, 80, 6 }), 4 };


        }
           
        
    }
}
