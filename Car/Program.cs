using System;

namespace Car
{
   class Program
    {   
       
        static void Main(string[] args)
        {
            CarCollection<Car> myList = new CarCollection<Car>();
            myList.Add(new Car("bmw","black","2010",10000));
            myList.Add(new Car("audi", "white","2007",8000));
            for (int i = 0; i < myList.Count; i++)
            {
                myList[i].print();
            }

            Console.WriteLine("Количество элементов: " + myList.Count);
            Console.WriteLine("---------------------------------------------");

            myList.del();
        }
    }
}
