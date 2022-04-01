using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.PositiveLinkedTests
{
    public class DeleteLastLinkedTest : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5});

            yield return new object[] { list,expected };

            list = new LinkedList(new int[] { 1, 2, 3, 4 });
            expected = new LinkedList(new int[] { 1, 2, 3 });

            yield return new object[] { list, expected };


        }
    }
}
