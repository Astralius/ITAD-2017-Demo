using System;

namespace _1.DerivedClassVirtual
{
    class Program
    {
        /// <summary>
        /// This example shows why you should avoid using virtual methods in constructors.
        /// 
        /// Usage:
        /// 0. Set this project as StartUp project.
        /// 1. Run the program as-is. Notice that base class (BaseData) constructor is invoked before the descendant class (NetworkData) constructor.
        /// 2. Uncomment lines 41-44 in BaseData.cs file. Run the program. Notice the null reference exception.
        /// 
        /// Explaination: 
        /// BaseData constructor called overriden method from descendant class (NetworkData) before calling the descendant class constructor.
        /// That's why NetworkData.source was still null.
        /// </summary> 
        static void Main(string[] args)
        {
            BaseData data = new NetworkData("testData", "http://giveMedata");
            Console.ReadKey();
        }
    }
}
