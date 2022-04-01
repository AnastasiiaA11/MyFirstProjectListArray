using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.PositiveLinkedTests
{
    public class AddInStartTestLinked : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 7;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            LinkedList expected = new LinkedList(new int[] { 7, 1, 2, 3, 4, 5, 6 });

            yield return new object[] { value, list, expected };

            value = -5;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            expected = new LinkedList(new int[] { -5, 1, 2, 3, 4, 5, 6 });

            yield return new object[] { value, list, expected };
        }
    }
}
