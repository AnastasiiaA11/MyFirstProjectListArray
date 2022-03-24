namespace MyFirstProjectListArray
{
    public class ClassListArray
    {
        public int Length { get; private set; }

        private int[] _array;

        public ClassListArray()
        {
            _array = new int[15];        
            Length = 0;
        }

        public ClassListArray(int element)
        {
            _array = new int[10];
            _array = new int[element];           
            Length = 0;
        }

        public ClassListArray(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                _array = new int[10];
                Length = 0;
            }
            else
            {
                _array = array;
                Length = array.Length;
                UpSize();
            }
        }


        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
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
            if (Length < 1)
            {
                throw new Exception("Length cannot be less 1");
            }
            if (index < 0 || index >= Length)
            {
                throw new IndexOutOfRangeException("index does not exist");
            }

            if (Length+1 >= _array.Length)
            {
                UpSize();
            }

            AddBeginning(index);

            _array[index] = value;
            Length++;
        }

        public void DeleteLast()
        {
            if (Length == 0)
            {
                throw new NotImplementedException();
            }
                
            
                DeletValue();
                     
            Length--;
        }

        public void DeletStart(int value)
        {
            if (Length >= _array.Length)
            {
                DeletValue();
            }
            _array[0] = value;
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

        public void DeletNEnd(int value)
        {
            Length = Length - value;
            int[] newArray=new int[Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array= newArray;

        }

        public void DeletNStart(int value)
        {
            Length = Length - value;
            int[] newArray = new int[Length];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = _array[i + value];
            }
            _array = newArray;
        }

        public void DeletNIndex(int index,int value)
        {
            Length = Length - value;
            int[] newArray = new int[Length];

            for (int i = index; i < index; i++)
                newArray[i] = _array[i];

            for (int i = index; i < newArray.Length; i++)
                newArray[i] = _array[i+value];

            _array = newArray;
        }

        public int ReturnRecovery(int value)
        {
            return Length;
        }
      
        public int AccessForIndex (int index)
        {
            return _array[index];
        }

        public int ShowIndex(int value)
        {
            int index = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    
                    return i;
                    
                }
            }
            return -1;
        }

        public void ChangeByIndex(int index,int value)
        {
            _array[index] = value;
        }

        public void ReverseArray ()
        {         
            for (int i = 0; i < Length / 2; i++)
            {
                int tmp = _array[i];
                _array[i] =_array[Length - (1 + i)];
                _array[Length-(1 + i)] = tmp;
            }            
        }

        public int SearchMax()
        {
            int maxValue;
            maxValue = _array[0];
            for (int i = 1; i < Length; i++)
            {

                if (_array[i] > maxValue)
                {
                    maxValue = _array[i];
                }
            }
            return maxValue;
        }

        public int SearchMin()
        {
            int minValue;
            minValue = _array[0];

            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < minValue)
                {
                    minValue = _array[i];
                    
                }

            }
            return minValue;
        }

        public int SearchIndexMax()
        {
            int maxValue = _array[0];
            int index = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > maxValue)
                {
                    maxValue = _array[i];
                    index = i;
                }

            }
            return index;
        }

        public int SearchIndexMin()
        {
            int minValue = _array[0];
            int index = 0;

            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < minValue)
                {
                    minValue = _array[i];
                    index = i;
                }

            }
            return index;
        }

        public void SortArrayByAge()
        {
            for (int i = 0; i < Length; i += 1)
            {
                for (int j = 1 + i; j < Length; j++)
                    if (_array[j] < _array[i])
                    {
                        int c = _array[i];
                        _array[i] = _array[j];
                        _array[j] = c;
                    }
            }
        }

        public void SortArrayDescending()
        {
            for (int i = 1; i < Length; i++)
            {

                int crnt = i;
                while (crnt != 0 && _array[crnt - 1] < _array[crnt])
                {
                    int tmp = _array[crnt];
                    _array[crnt] = _array[crnt - 1];
                    _array[crnt - 1] = tmp;
                    crnt--;
                }
            }
        }

        public int DeleteValueFirst(int value)
        {
            int count = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i - count] = _array[i];
                }
            }
            Length -= count;

            return count;
        }

        public int ReturnAmountDeleted(int value)
        {
           
            int sum = 0;
            for (int i = 1; i < Length; i ++)
            {
                if (_array[i] == value)
                {
                    sum++;
                }
                else
                {
                    _array[i - sum] = _array[i];
                }
            }
            Length = Length-sum;
            return sum;
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

        public override string ToString()
        {
            string s = "[";

            for (int i = 0; i < Length; i++)
            {
                s += $"{_array[i]} ";
            }
            s += "]";
            return s;
        }

        public override bool Equals(object? obj)
        {
            bool isEqual = true;

            if (obj == null || !(obj is ClassListArray))
            {
                isEqual = false;
            }
            else
            {
                ClassListArray list = (ClassListArray)obj;

                if (list.Length != this.Length)
                {
                    isEqual = false;
                }
                else
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            isEqual = false;
                        }
                    }
                }
            }
            return isEqual;
        }


        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];
            Copy(newArray);
        }

        private void AddBeginning(int index=0)
        {
            int[] newArray = new int[Length + 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = index; i < Length; i++)
            {
                newArray[i + 1] = _array[i];
            }
            _array = newArray;
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