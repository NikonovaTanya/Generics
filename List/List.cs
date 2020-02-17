using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class List<T>
    {
        public List()
        { list = new T[10];
        }
        
        private T[] list;
        private int count=0;
        
        public int Count
        { get { return count; }
        }
        public T this[int index]
        { get { return list[index]; }
          set { list[index] = value; }
        }
        public void Add(T elem)
        { list[count]=elem;
          count++;
        }
    }
}

