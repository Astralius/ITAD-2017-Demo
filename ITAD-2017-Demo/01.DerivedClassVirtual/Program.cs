using System;

namespace _1.DerivedClassVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseData data = new NetworkData("testData", "http://giveMedata");
            Console.ReadLine();
        }
    }
}
