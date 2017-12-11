using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Closure
{
    class Program
    {
        static void Main(string[] args)
        {
            TestForeach();
            Console.ReadKey();
            Console.WriteLine();

            TestFor();
            Console.ReadLine();
        }

        public static void TestForeach()
        {
            Console.WriteLine(nameof(TestForeach));

            var actionsForeach = new List<Action>();
            foreach (var i in Enumerable.Range(0, 3))
            {
                actionsForeach.Add(() => Console.WriteLine(i));
            }
            foreach (var action in actionsForeach)
            {
                action();
            }
        }

        public static void TestFor()
        {
            Console.WriteLine(nameof(TestFor));

            var actionsFor = new List<Action>();
            for (int i = 0; i < 3; ++i)
            {
                actionsFor.Add(() => Console.WriteLine(i));
            }
            for (int i = 0; i < 3; ++i)
            {
                actionsFor[i]();
            }
        }
    }
}
