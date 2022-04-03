using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProjectListArray
{
    public class LinkedList

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
