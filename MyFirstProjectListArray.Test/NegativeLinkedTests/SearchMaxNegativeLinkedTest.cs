using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.NegativeLinkedTests
{
    public class SearchMaxNegativeLinkedTest: IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
           
            LinkedList list = new LinkedList(new int[] { });

            yield return new object[] {list };        
        }
    }
}
