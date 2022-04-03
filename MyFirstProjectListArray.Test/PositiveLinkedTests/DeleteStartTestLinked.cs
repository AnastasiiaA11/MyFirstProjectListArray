using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.PositiveLinkedTests
{
    public class DeleteStartTestLinked: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
 
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            LinkedList expected = new LinkedList(new int[] { 2, 3, 4, 5, 6 });

            yield return new object[] { list, expected };
        }

    }
}
