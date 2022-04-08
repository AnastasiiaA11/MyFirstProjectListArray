using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.PositiveLinkedTests
{
    internal class AddListLastTestLinked:IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            LinkedList actuallistSecnd = new LinkedList(new int[] { 9, 2, 6 });
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 9, 2, 6 });

            yield return new object[] { actuallist, actuallistSecnd, expected };




        }
    }
}
