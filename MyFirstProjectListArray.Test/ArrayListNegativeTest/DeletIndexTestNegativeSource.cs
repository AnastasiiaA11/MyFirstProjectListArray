using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListNegativeTestSources
{
    internal class DeleteIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            ClassListArray actuallist = new ClassListArray(new int[] { });

            yield return new object[] { index,actuallist };

        }
    }

    internal class DeleteIndexNegativeTestSource_WhenIndexOutOfRange : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {


            int index = -2;
            ClassListArray actuallist = new ClassListArray(new int[] { 15, 4, 8, 1 });

            yield return new object[] { index, actuallist };

            index = 8;
           actuallist = new ClassListArray(new int[] { 15, 4, 8, 1 });

            yield return new object[] { index, actuallist };
        }
    }
}
