using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class DynamicArray<T> : IEnumerable<T> where T : IComparable<T>, new()
    {
        public T[] arr;
        private int length;

        public DynamicArray()
        {
            arr = new T[8];
            Length = 0;
        }

        public DynamicArray(int capacity)
        {
            arr = new T[capacity];
            Length = 0;
        }

        public DynamicArray(T[] mas)
        {
            arr = new T[mas.Length];
            mas.CopyTo(arr, 0);
            Length = mas.Length;
        }

        public DynamicArray(IEnumerable<T> mas)
        {
            arr = mas.ToArray();
            length = arr.Length;
        }

        public void Add(T element)
        {
            if (Length == Capacity)
            {
                T[] arrayNew = new T[Length * 2];
                arr.CopyTo(arrayNew, 0);
                arrayNew[Length] = element;
                arr = arrayNew;
                Length++;
            }
            else
            {
                arr[Length] = element;
                Length++;
            }
        }

        public void AddRange(T[] element)
        {
            if (Length + element.Length > Capacity)
            {
                T[] arrayNew = new T[Length + element.Length];
                arr.CopyTo(arrayNew, 0);
                element.CopyTo(arrayNew, arrayNew.Length);
                arr = arrayNew;
            }
            else
            {
                arr = element;
                length += element.Length;
            }
        }

        public bool RemoveIndex(int index)
        {
            if (index >= Length)
            {
                return false;
            }
            for (int i = index; i < Length; i++)
            {
                arr[i-1] = arr[i];
            }
            length--;
            arr[Length] = default(T);
            return true;
        }

        public bool Remove(T element)
        {
            int index = Array.IndexOf(arr, element);
            if (index == -1)
            {
                return false;
            }
            for (int i = index; i < Length-1; i++)
            {
                arr[i] = arr[i+1];
            }
            length--;
            arr[Length] = default(T);
            return true;
        }

        public void Insert(T element, int index)
        {
            if (index > Length)
            {
                throw new IndexOutOfRangeException("Wrong index");
            }
            T[] arrayNew;
            if (Length == Capacity)
            {
                arrayNew = new T[Capacity * 2];
            }
            else
            {
                arrayNew = new T[Capacity];
            }
            Array.Copy(arr, 0, arrayNew, 0, index);
            arrayNew[index] = element;
            Array.Copy(arr, index, arrayNew, index+1, Length - index);
            arr = arrayNew;
            Length++;
        }

        public void SortArray()
        {
            T k;
            for (int i = 0; i < Length; i++)
            {
                for (int j = i; j < Length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
                    {
                        k = arr[i];
                        arr[i] = arr[j];
                        arr[j] = k;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return arr[i];
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
            private set
            {
                length = value;
            }
        }

        public int Capacity
        {
            get
            {
                return arr.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= Capacity)
                {
                    throw new IndexOutOfRangeException("Wrong index");
                }
                return arr[index];
            }
            set
            {
                if (index >= Capacity)
                {
                    throw new IndexOutOfRangeException("Wrong index");
                }
                if (index >= Length)
                {
                    length++;
                }
                arr[index] = value;
            }
        }
    }
}
