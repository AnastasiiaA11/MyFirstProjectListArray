using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.PositiveLinkedTests
{
    public class DeleteNStartTestLinked: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 2;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            LinkedList expected = new LinkedList(new int[] { 3, 4, 5, 6 });

            yield return new object[] { value, list, expected };

            value = 4;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 7,5,-5,5,9,6 });
            expected = new LinkedList(new int[] { 7, 5, -5, 5, 9, 6 });
            yield return new object[] { value, list, expected };
        }
    }
}
