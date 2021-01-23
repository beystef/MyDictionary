using System;

namespace Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> dict1 = new MyDictionary<int,string>();
            dict1.Add(1, "Elma");
            dict1.Add(2, "Armut");
            Console.WriteLine(dict1.Get(1));
            Console.WriteLine(dict1.Get(2));
        }
    }
}
