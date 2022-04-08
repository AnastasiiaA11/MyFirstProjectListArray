using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.PositiveLinkedTests
{
    public class SearchMaxTestLinked: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int expected =  6;

            yield return new object[] { actuallist, expected };

            actuallist = new LinkedList(new int[] { 10, 2, 30, 4, 15, 0 });
            expected = 30;

            yield return new object[] { actuallist, expected };
        }
    }
}
