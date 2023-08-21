using System;
using System.Collections;

namespace SimpleWebApi.Models.Tasks
{
    public class CustomList<T> : IList<T> where T : IComparable<T>
    {
        private T[] array;


        public CustomList() { _count = array.Length; }

        public CustomList(T[] _array)
        {
            array = _array;
            _count = array.Length;
        }

        public T[] GetItems()
        {
            return array;

        }

        public T this[int index] { get => array[index]; set => array[index] = value; }

        private int _count ;
        public int Count => _count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            Array.Resize(ref array, Count + 1);
            _count++;
            array[Count - 1] = item;
        }

        public void Clear()
        {
            array = new T[0];
            _count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(item)) return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(array[i], arrayIndex++);
            }
        }


        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i].Equals(item)) return i;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            Array.Resize<T>(ref array, Count + 1);
            _count++;

            for (int i = Count; i >= index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = item;
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            (array[index], array[Count - 1]) = (array[Count - 1], array[index]);

            Array.Resize(ref array, Count - 1);
            _count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];

            }
        }
        public void Sort()
        {
            int max;

            for (int i = Count; i >= 0; i--)
            {
                max = 0;
                for (int j = 1; j < i; j++)
                {
                    if (array[max].CompareTo(array[j]) < 0) max = j;

                }
                if (max != i) (array[max], array[i - 1]) = (array[i - 1], array[max]);
            }

        }
    }
}
