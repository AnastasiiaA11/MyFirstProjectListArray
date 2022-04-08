using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.PositiveLinkedTests
{
    public class ChangeByIndexTestLinked:IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 8;
            int index = 1;
            LinkedList actuallist = new LinkedList(new int[] { 2, 2, 1, 4, 8, 6 });
            LinkedList expected = new LinkedList(new int[] { 2, 8, 1, 4, 8, 6 });

            yield return new object[] { index, value, actuallist, expected };          
        }
    }
}
