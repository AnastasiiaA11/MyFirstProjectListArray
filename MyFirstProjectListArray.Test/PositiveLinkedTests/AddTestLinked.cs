using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.PositiveLinkedTests
{
    public class AddTestLinked : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 7;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });

            yield return new object[] { value, list, expected };        
        }
    }
}
