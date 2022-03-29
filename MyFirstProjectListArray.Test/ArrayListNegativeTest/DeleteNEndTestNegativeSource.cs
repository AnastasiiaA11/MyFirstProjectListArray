using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListNegativeTestSources
{
    internal class DeleteNEndNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 1;
            ClassListArray actuallist = new ClassListArray(new int[] { });

            yield return new object[] { value, actuallist };
        }
    }

        internal class DeleteNEndNegativeTestSource_ArgumentOutOfRangeException : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                int value = 10;
                ClassListArray actuallist = new ClassListArray(new int[] { 9, 2, 6, 7 });

                yield return new object[] { value, actuallist };

                value = -10;
                actuallist = new ClassListArray(new int[] { 5, 9, 3 });

                yield return new object[] { value, actuallist };
            }
        }  
}
