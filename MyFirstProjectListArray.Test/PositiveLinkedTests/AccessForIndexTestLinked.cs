using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.PositiveLinkedTests
{
    public class AccessForIndexTestLinked:IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 3;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int expected = 4;

            yield return new object[] { index, list, expected };

            index = 0;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = 1;
            yield return new object[] { index, list, expected };
        }
    }
}
