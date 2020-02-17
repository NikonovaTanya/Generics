using System;

namespace List
{ 
   static  class Program
    {
       
        public static T[] GetArray<T>(this List<T> list)
        {
            T[] array = new T[10];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("List типа int:");
            List<int> myList= new List<int>();
            myList.Add(3);
            myList.Add(2);
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);
            Console.WriteLine("Количество элементов: "+myList.Count);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("List типа double:");
            List<double> myList1 = new List<double>();
            myList1.Add(5.2);
            Console.WriteLine(myList1[0]);
            Console.WriteLine("Количество элементов: " + myList1.Count);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Элементы массива (после вызова функции расширяющего метода GetArray()):");
            int[] myArray = new int[10];
            myArray=myList.GetArray<int>();
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("myArray[{0}]: {1}",i,myArray[i]);
            }
        }
    }
}
