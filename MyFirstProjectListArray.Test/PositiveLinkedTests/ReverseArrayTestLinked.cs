using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.PositiveLinkedTests
{
    public class ReverseArrayTestLinked: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            
            LinkedList actuallist = new LinkedList(new int[] { 8, 2, 1, 4, 8, 6 });
            LinkedList expected = new LinkedList(new int[] { 6,8,4,1,2,8 });

            yield return new object[] {actuallist, expected };

            actuallist = new LinkedList(new int[] { -8, 2, -1, 4, 8, 6 });
            expected = new LinkedList(new int[] { 6, 8, 4, -1, 2, -8 });

            yield return new object[] { actuallist, expected };
        }
    }
}
