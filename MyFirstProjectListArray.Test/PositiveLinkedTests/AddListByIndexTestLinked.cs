using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.PositiveLinkedTests
{
    internal class AddListByIndexTestLinked : IEnumerable

    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            LinkedList actuallist = new LinkedList(new int[] { 1, 11, 3, 4, 5, 6 });
            LinkedList actuallistSecnd = new LinkedList(new int[] { 9, 2, 12 });
            LinkedList expected = new LinkedList(new int[] { 1, 11, 9, 2, 12,3, 4, 5, 6 });

            yield return new object[] { index,actuallist, actuallistSecnd, expected };
        }

    }

}

