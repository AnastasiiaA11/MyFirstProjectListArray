using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyFirstProjectListArray
{
    public interface IMyList
    {
        //Node _root { get; set; }
        

        public int this[int index] { get; set; }

        //public int Length { get; set; }
        public int SearchMin();

        public int SearchIndexMax();  
        
        public int SearchIndexMin();
        public void SortArrayByAge();
        public void SortArrayDescending();
        public int DeleteValueFirst(int value);
        public int ReturnAmountDeleted(int value);
        
       
    }
}
