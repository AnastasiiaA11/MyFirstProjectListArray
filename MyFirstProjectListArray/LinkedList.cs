using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray
{
    public class LinkedList : IMyList
    {
        private Node _root;

        private Node _tail;

        public int this[int index]
        {
            get
            {
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                return crnt.Value;
            }

            set
            {
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                crnt.Value=value;
            }
        }
        public LinkedList(int[] values)
        {
            if (values.Length == 0)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                _root = new Node(values[0]);
                _tail = _root;

                for (int i = 1; i < values.Length; i++)
                {
                    Add(values[i]);
                }
            }
        }

        public int Length
        {
            get
            {
                int count = 0;
                Node crnt = _root;

                while (crnt != null)
                {
                    crnt = crnt.Next;
                    count++;
                }

                return count;
            }
            private set
            {
            }
        }

        public LinkedList()
        {
            _root = null;

            _tail = null;
        }

        public LinkedList(int value)
        {
            _root = new Node(value);
            _tail = _root;
        }

        public void Add(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                //Node crnt = _root;

                //while (crnt.Next != null)
                //{
                //    crnt = crnt.Next;
                //}

                //crnt.Next = new Node(value);

                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }

        }

        public void AddInStart(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                Node crnt = _root;
                _root=new Node(value);
                _root.Next = crnt;

            }
        }
        public void AddIndex(int index, int value)
        {
            if (index<0 || index>Length)
            {
                throw new IndexOutOfRangeException("index does not exist");
            }
            Node tmp = _root;
            for (int i = 0; i < index - 1; i++)
            {
                tmp = tmp.Next;
            }
            Node crnt = new Node(value);
            crnt.Next = tmp.Next;
            tmp.Next = crnt;

        }
        public void DeleteLast()
        {
            
            Node crnt = _root;
            while(crnt.Next.Next!=null)
            {
                crnt = crnt.Next;
            }
            _tail = crnt;
            _tail.Next = null;                  
        }

        public void DeleteStart()
        {
            if(this==null)
            {
                throw new Exception("");
            }
           
            _root=_root.Next;                    
        }

        public void DeleteIndex(int index)
        {
            if (index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                _root = _root.Next;
            }
            else
            {
                Node crnt = GetNodeByIndex(index - 1);
                crnt.Next = crnt.Next.Next;
            }
        }
        public void DeleteNEnd(int value)
        {
            if (value < 0 || value > Length - 1)
            {
                throw new Exception("");
            }
            Node crnt = _root;
           for(int i=1; i<Length-value;i++)
            {
                crnt = crnt.Next;
            }
            _tail = crnt;
            _tail.Next = null;
        }

        public void DeleteNStart(int value)
        {
            if (value < 0 || value > Length - 1)
            {
                throw new Exception("");
            }
            Node crnt = _root;
            for (int i = 0; i < value; i++)
            {
                crnt = crnt.Next;
            }
            _root = crnt;

        }
        public void DeleteNIndex(int index, int value)
        {
            if (index<0|| index>Length-1)
            {
                throw new Exception("");
            }
            Node crnt = GetNodeByIndex(index - 1);
            Node tmp = GetNodeByIndex(index + value);

            if (index == 0)
            {
                _root = tmp;
            }
            else
            {
                crnt.Next = tmp;
            }
            _tail = GetNodeByIndex(Length - 1);


        }

        public int  ReturnRecovery()
        {
            return Length;
            
        }
        public void AccessForIndex(int index)
        {
            Node crnt = GetNodeByIndex(index);
        }
        public int ShowIndex(int value)
        {
            int index = -1;
            Node crnt = _root;
            for(int i = 0; i < Length; i++)
            {
                if(crnt.Value==value)
                {
                    index = i;
                    break;
                }
                crnt = crnt.Next;
            }
            return index;
        }

        public void ChangeByIndex(int index, int value)
        {
            if(index<0|| index>Length-1)
            {
                throw new IndexOutOfRangeException();
            }
            GetNodeByIndex(index).Value = value;
            
        }
        public void ReverseArray()
        {
           
            Node oldRoot = _root;
            while (oldRoot.Next != null)
            {
                Node tmp = oldRoot.Next;
                oldRoot.Next = oldRoot.Next.Next;
                tmp.Next = _root;
                _root = tmp;
            }
            _tail = oldRoot;
        }

        public int SearchMax()
        {
            if (Length==0)
            {
                throw new Exception();
            }
            int maxValue = _root.Value;
            Node crnt= _root;
            while (crnt != null)
            {
                if (maxValue < crnt.Value)
                {
                    maxValue = crnt.Value;
                 }
                crnt = crnt.Next;

            }
            return maxValue;
        }

        public int SearchMin()
        {
            if (Length == 0)
            {
                throw new Exception();
            }
            int minValue = _root.Value;
            Node crnt = _root;
            while (crnt != null)
            {
                if (minValue > crnt.Value)
                {
                    minValue = crnt.Value;
                }
                crnt = crnt.Next;

            }
            return minValue;
        }

        public int SearchIndexMax()
        {         

            int index = 0;

            int maxValue = _root.Value;
            Node crnt = _root;
            for (int i = 0; i < Length; i++)
            {
                if (crnt.Value > maxValue)
                {
                    index = i;
                    maxValue = crnt.Value;
                }
                crnt = crnt.Next;
            }
            return index;
         
        }

        public int SearchIndexMin()
        {
 
            int index = 0;

            int minValue = _root.Value;
            Node crnt = _root;
            for (int i = 0; i < Length; i++)
            {
                if (crnt.Value < minValue)
                {
                    index = i;
                    minValue = crnt.Value;
                }
                crnt = crnt.Next;
            }
            return index;
        }
             
            public void SortArrayByAge()
            {
                int l = Length;
                Node crnt;
                Node prev;

                for (int i = l - 2; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        crnt = _root;
                        if (crnt.Next != null && crnt.Value > crnt.Next.Value)
                        {
                            _root = crnt.Next;
                            crnt.Next = _root.Next;
                            _root.Next = crnt;
                        }
                        prev = _root;
                    }
                    else
                    {
                        prev = GetNodeByIndex(i - 1);
                        crnt = prev.Next;
                    }

                    while (crnt.Next != null && crnt.Value > crnt.Next.Value)
                    {
                        prev.Next = crnt.Next;
                        crnt.Next = prev.Next.Next;
                        prev.Next.Next = crnt;

                        prev = prev.Next;
                    }
                }

                _tail = GetNodeByIndex(l - 1);
            }
        public void SortArrayDescending()
        {
            int l = Length;
            Node crnt;
            Node prev;

            for (int i = l - 2; i >= 0; i--)
            {
                if (i == 0)
                {
                    crnt = _root;
                    if (crnt.Next != null && crnt.Value < crnt.Next.Value)
                    {
                        _root = crnt.Next;
                        crnt.Next = _root.Next;
                        _root.Next = crnt;
                    }
                    prev = _root;
                }
                else
                {
                    prev = GetNodeByIndex(i - 1);
                    crnt = prev.Next;
                }

                while (crnt.Next != null && crnt.Value < crnt.Next.Value)
                {
                    prev.Next = crnt.Next;
                    crnt.Next = prev.Next.Next;
                    prev.Next.Next = crnt;

                    prev = prev.Next;
                }
            }

            _tail = GetNodeByIndex(l - 1);
        }

        public int DeleteValueFirst(int value)
        {
            
            Node crnt = _root;
            for (int i = 0; i < Length; i++)
            {
                int index=i;
                if (crnt.Value == value)
                {
                    DeleteIndex(index);
                    return index;
                }
                crnt = crnt.Next;
            }
           
            return -1;
        }

        public int ReturnAmountDeleted(int value)
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to delete");
            }

            Node crnt = _root;
            int index = 0;
            int count = 0;
            while(crnt!=null)
            {
                index = DeleteValueFirst(value);

                if (index!=-1)
                {
                    GetNodeByIndex(index);
                    count++;
                }
                crnt = crnt.Next;
            }
            return count;
        }

        public void AddListLast(LinkedList list)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }
            _tail.Next = list._root;
            _tail = _tail.Next;
            Length+=list.Length;

        }
        public void AddListFirst(LinkedList list)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }
            LinkedList tmpList = new LinkedList();
            tmpList = tmpList.CopyList(list);
            tmpList._tail.Next = _root;
            _root = tmpList._root;
            
        }
        public void AddListByIndex(LinkedList list, int index)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }
            LinkedList tmpList = new LinkedList();
            tmpList = tmpList.CopyList(list);
            Node tmp = _root;
            Node crnt = tmpList._root;
            for (int i = 0; i < index - 1; i++)
            {
                tmp = tmp.Next;
            }
            while (crnt.Next != null)
            {
                crnt = crnt.Next;
            }
            crnt.Next = tmp.Next;
            tmp.Next = tmpList._root;
        }
        public override string ToString()
        {
            string s = "";
            Node crnt = _root;

            while (crnt != null)
            {
                s += $"{crnt.Value} ";
                crnt = crnt.Next;
            }

            return s;
        }


        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is LinkedList))
            {
                return false;
            }

            LinkedList list = (LinkedList)obj;

            if (list.Length != this.Length)
            {
                return false;
            }

            Node thisCrnt = this._root;
            Node listCrnt = list._root;

            while (thisCrnt != null)
            {
                if (thisCrnt.Value != listCrnt.Value)
                {
                    return false;
                }

                thisCrnt = thisCrnt.Next;
                listCrnt = listCrnt.Next;
            }

            return true;
        }
        private LinkedList CopyList(LinkedList list)
        {
            Node crnt= list._root;
            LinkedList tmpList = new LinkedList();
            for(int i=0; i<list.Length; i++)
            {
                tmpList.Add(crnt.Value);
                crnt = crnt.Next;
            }
            return tmpList;
        }
        private Node GetNodeByIndex(int index)
        {
            Node crnt = _root;
            for (int i = 1; i <= index; i++)
            {
                crnt = crnt.Next;
            }

            return crnt;
        }
    }

   
}
