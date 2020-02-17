using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    public class Car
    {   string name;
        string color;
        string year;
        int price;

        public Car() { }
        public Car(string name, string color,string year, int price) 
        {
            this.name = name;
            this.color = color;
            this.year = year;
            this.price = price;
        }
        public string Name
        {
            set {  name = value; }
            get {  return name;  }
        }
        public string Color
        {
            set { color = value; }
            get { return color;  }
        }
        public string Year
        {
            set { year = value; }
            get { return year; }
        }

        public int Price
        {  set  { price= value; }
            get { return price;  }
        }
        public void print()
        {
            Console.Write(name+"  "+ color+"   "+ year+"   " + price);
            Console.WriteLine();
        }
    }
   
}
