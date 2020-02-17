using System;

namespace Generics
{
    public class MyClass<T> where T: new()
    {
      public static T FactoryMethod()
      { T obj = new T();
            return obj;
        }
    }

    public class Printer
    {  public void pr()
        {
            Console.WriteLine("Print");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyClass<int>.FactoryMethod());
            Console.WriteLine(MyClass<double>.FactoryMethod());
            Console.WriteLine(MyClass<bool>.FactoryMethod());
            Console.WriteLine(MyClass<Printer>.FactoryMethod());
          }
    }
}
