using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task_2_3
{
    class MyList:IList
    {
        private object[] myListOdjects;
        private int _count;

        public MyList(int Length)
        {
            myListOdjects = new object[Length];
            _count = 0;
        }

        public int Add(object newObject)
        {
            if (_count < myListOdjects.Length)
            {
                myListOdjects[_count] = newObject;
                _count++;
                return _count;
            }
            else
            {
                return -1;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public void CopyTo(Array array, int index)
        {
            foreach (object i in myListOdjects)
            {
                if (i == null) break;
                array.SetValue(i, index);
                index++;
            }
        }
        public void Clear()
        {
            _count = 0;
            myListOdjects = new object[myListOdjects.Length];
        }
        public bool Contains(object obj)
        {
            bool contains=false;

            foreach (object i in myListOdjects)
            {

                if (i == obj) 
                {
                    contains = true;
                    break;
                }
                    
            }
            return contains;
        }        

        public int IndexOf(object obj)
        {
            int indexOf=-1;
            for (int i = 0; i < myListOdjects.Length; i++)
            {
                if (myListOdjects[i] == obj)
                {
                    indexOf = i;
                    break;
                }                    
            }
            return indexOf;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (object obj in myListOdjects)
            {
                yield return obj;
            }

        }
        public void Insert(int index, object obj)
        {
            if ((index != 0) || (index < _count))
            {
                if (_count + 1 <= myListOdjects.Length)
                {
                    for (int i = _count - 1; i > index; i--)
                    {
                        myListOdjects[i + 1] = myListOdjects[i];
                    }
                    _count++;
                    myListOdjects[index] = obj;
                }
                else
                {
                    Console.WriteLine("Array is crowded");
                }
            }
            else
            {
                Console.WriteLine("Index over the limit");
            }
            
        }
        public void Remove(object obj)
        {
            RemoveAt(IndexOf(obj));
        }

        public void RemoveAt(int index)
        {
            if ((index < _count) && (index >=0))
            {
                for (int i = index; i < _count - 1; i++)
                {
                    myListOdjects[i] = myListOdjects[i + 1];
                }
                _count--;
            }
        }

        public void Print()
        {
            foreach (object i in myListOdjects)
            {
                if (i == null) break;
                Console.WriteLine(i);

            }
        }

        public object this[int index]
        {
            get
            {
                return myListOdjects[index];
            }
            set
            {
                myListOdjects[index] = value;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return true;
            }
        }
        public object SyncRoot
        {
            get
            {
                return this;
            }
        }
        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
    }
}
