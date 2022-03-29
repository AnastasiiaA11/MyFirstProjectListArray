using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray.Test.ArrayListNegativeTestSources
{    
        internal class ChangeByIndexNegativeTestSource : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                int index = 0;
                int value = 1;
                ClassListArray actuallist = new ClassListArray(new int[] { });

            yield return new object[] { index, value, actuallist };

            }
        }
        internal class ChangeByIndexNegativeTestSource_IndexOutOfRangeException : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                int index = -1;
                int value = 10;
                ClassListArray actuallist = new ClassListArray(new int[] { 9, 2, 6, 7 });
                

            yield return new object[] { index, value, actuallist};

                index = 3;
                value = -10;
                actuallist = new ClassListArray(new int[] { 5, 9, 3 });
               

            yield return new object[] { index, value, actuallist};
            }
        }   
}
