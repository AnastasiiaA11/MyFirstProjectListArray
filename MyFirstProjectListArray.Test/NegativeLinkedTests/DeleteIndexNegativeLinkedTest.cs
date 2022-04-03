using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.NegativeLinkedTests
{
    public class DeleteIndexNegativeLinkedTest : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = -2;
            
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });


            yield return new object[] { index , list };


        }
    }
}
