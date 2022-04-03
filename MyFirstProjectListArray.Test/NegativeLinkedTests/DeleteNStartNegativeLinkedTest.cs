using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.NegativeLinkedTests
{
    public class DeleteNStartNegativeLinkedTest: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = -2;

            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });


            yield return new object[] { value, list };

             value = 15;

             list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });


            yield return new object[] { value, list };
        }
    }
}
