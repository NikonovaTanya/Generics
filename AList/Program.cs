using System;

namespace AList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList aList=new MyList();
            aList.Add(3);
            aList.Add(2.1);
            Console.WriteLine("Количество элементов  ArrayList:" + aList.Count);
            aList.PrintElement();
            aList.Insert(2,2.2);
            Console.WriteLine("Количество элементов после insert(ставка элемента перед элементом с индексом 2) ArrayList:" + aList.Count);
            aList.PrintElement();
            aList.RemoveAt(0);
            Console.WriteLine("Количество элементов после удаления 0-элемента  ArrayList:" + aList.Count);
            aList.PrintElement();
            aList.Remove(2.2);
            Console.WriteLine("Количество элементов после удаления элемента равного 2.2  ArrayList:" + aList.Count);
            aList.PrintElement();

            aList.Clear();
            Console.WriteLine("Количество элементов после выполнения clear() ArrayList:" + aList.Count);

        }
    }
}
