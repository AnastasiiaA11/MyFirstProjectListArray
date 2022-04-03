using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.PositiveLinkedTests
{
    public class DeleteIndexTestLinked : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 3;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 5, 6 });

            yield return new object[] { index,list, expected };

            index = 0;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = new LinkedList(new int[] { 2, 3, 4,5 });
            yield return new object[] { index, list, expected };
        }
    }
}
