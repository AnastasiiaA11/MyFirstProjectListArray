namespace MyFirstProjectListArray
{
    public class ClassListArray
    {
        public int Length { get; private set; }

        private int[] _array;

        public ClassListArray()
        {
            _array = new int[10];
            Length = 6;
        }

        public void Add(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }

            _array[Length] = value;
            Length++;
        }        
                     
        public void AddInStart(int value)
        {
            if (Length+1 >= _array.Length)
            {
                UpSize();
            }
            AddBeginning();

            _array[0] = value;
            Length++;
        }
        
        public void AddIndex(int index,int value)
        {
            if (Length+1 >= _array.Length)
            {
                UpSize();
            }

            AddBeginning(index);

            _array[index] = value;
            Length++;
        }

        public void DeletLast(int value)
        {
            if (Length>= _array.Length)
            {
                DeletValue();
            }
            _array[0] = value;
            Length--;
        }

        public void DeletStart()
        {
            if (Length >= _array.Length)
            {
                DeletValue();
            }
            
            Length--;
        }

        public void DeletIndex(int index,int value)
        {
            {
                DeletIndex();
            }
            _array[index] = value;
            Length--;
        }

        public void Write()
        {
            Console.Write($"L={Length} RL={_array.Length}   ");
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i]} ");
            }
            Console.WriteLine();
        }

        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];
            Copy(newArray);
        }

        private void AddBeginning(int index=0)
        {
            int[] newArr = new int[Length + 1];
           
            for (int i = index; i < Length; i++)
            {
                newArr[i + 1] = _array[i];
            }
            _array = newArr;
        }

        private void Copy(int[] newArray)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        private void DeletValue()
        {
            int newLength = _array.Length -1;
            int[] newArray = new int[newLength];
            Copy(newArray);
        }

        private void DeletIndex(int index = 0)
        {
            int[] newArr = new int[Length - 1];

            for (int i = index; i < index; i++)          
                newArr[i] = _array[i];
            
            for (int i=index+1;i< Length; i++)           
                 newArr[i-1] = _array[i];
            
           
        }
    }
}