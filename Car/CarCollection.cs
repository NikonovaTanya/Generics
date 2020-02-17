using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class CarCollection<T> where T: class 
    {
        public CarCollection()
        {
            myCollection = new T[10];
        }

        private T[] myCollection;
        private int count = 0;

        public int Count
        {
            get { return count; }
        }
        public T this[int index]
        {
            get { return myCollection[index]; }
            set { myCollection[index] = value; }
        }
        public void Add(T elem)
        {
            myCollection[count] = elem;
            count++;
        }
        public void del()
        {   for (int i = 0; i < count; i++)
            {
                myCollection[i] = null;
            }
            count = 0;
            Console.WriteLine("Все элементы удалены!");
        }
    }
}
