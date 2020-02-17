using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<DOUBLE, DOUBLE> ");
            Dictionary<double, double> myDictionary = new Dictionary<double,double>();
            myDictionary.Add(0.5,4.2);
            myDictionary.Add(2.1,5.3);
            Console.WriteLine(myDictionary[0]+"   "+ myDictionary[myDictionary[0]]);
            Console.WriteLine(myDictionary[1] + "   " + myDictionary[myDictionary[1]]);
            Console.WriteLine("Количество элементов: " + myDictionary.Count);

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("<STRING, INT> ");
            Dictionary<string, int> myDictionary1 = new Dictionary<string, int>();
            myDictionary1.Add("ноябрь", 11);
            myDictionary1.Add("декабрь", 12);
            Console.WriteLine(myDictionary1[0] + "   " + myDictionary1[myDictionary1[0]]);
            Console.WriteLine(myDictionary1[1] + "   " + myDictionary1[myDictionary1[1]]);
            Console.WriteLine("Количество элементов: " + myDictionary1.Count);

        }
    }
}
