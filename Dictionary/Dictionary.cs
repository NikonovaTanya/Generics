using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    public class Dictionary<TKey, TValue>
    {
        private TKey[] myKey=new TKey[10];
        private TValue[] myValue = new TValue[10];


        private int count = 0;
        public int Count
        {
            get { return count; }
        }
        public TKey this[int index]
        {
            get
            {
               return myKey[index]; 
              
            }
            set 
            {  myKey[index]=value;
                
            }
        }

        public TValue this[TKey index]
        {
            get
            { for (int i=0;i<count;i++)
                if(index.Equals(myKey[i]))
                    return myValue[i];
                return myValue[count];
            }
            
        }

        public void Add(TKey key, TValue value)
        {
            myKey[count] = key;
            myValue[count]= value;
            count++;
       }
        public void print()
        { for (int i = 0; i < count; i++)
            {
                Console.WriteLine(myKey[i]+" "+myValue[i]);
          }
        }
    }
}
