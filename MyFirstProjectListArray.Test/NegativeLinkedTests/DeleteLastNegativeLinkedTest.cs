using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.NegativeLinkedTests
{
    public class DeleteLastNegativeLinkedTest : IEnumerable
    {      
        
            public IEnumerator GetEnumerator()
            {
                
                LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
               LinkedList expectedList = null;



            yield return new object[] { list,expectedList };


            }      

    }
}
