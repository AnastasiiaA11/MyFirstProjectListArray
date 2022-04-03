using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.PositiveLinkedTests
{
   public class ShowIndexTestLinked: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 8;
            LinkedList actuallist = new LinkedList(new int[] { 2, 8, 1, 4, 8, 6 });
            int expected = 1;

            yield return new object[] { value, actuallist, expected };

            value = 4;
            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            expected = 3;

            yield return new object[] { value, actuallist, expected };

           
        }
    }
}
