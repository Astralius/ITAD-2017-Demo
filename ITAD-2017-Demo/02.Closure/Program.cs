using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Closure
{
    class Program
    {
        /// <summary>
        /// This example shows dangers of passing parameters to anonymous methods in a loop.
        /// 
        /// Usage:
        /// 1. Hit Start (F5) and inspect the values returned by the TestFor method.
        /// 2. Hit any key and inspect the value returned by the TestForeach method. Notice the difference.
        /// 
        /// Explaination:
        /// While creating a lambda expression, the parameters are wrapped into a class and saved on the heap.
        /// That's why, when executing these anonymous methods, the last saved value of the parameter is used.
        /// </summary> 
        static void Main(string[] args)
        {
            Program.TestFor();
            Console.ReadKey(true);

            Console.WriteLine();
            Program.TestForeach();
            Console.ReadKey();
        }

        /// <summary>
        /// This method will show unwanted behaviour.
        /// </summary>
        public static void TestFor()
        {
            Console.WriteLine(nameof(TestFor));

            var actionsFor = new List<Action>();

            // Each consecutive number is the value of the same variable (one address in memory).
            for (int number = 0; number < 3; ++number)
            {
                actionsFor.Add(() => Console.WriteLine(number));  // number will be passed by reference rather than by value.
            }

            // Execute all actions
            for (int index = 0; index < 3; ++index)
            {
                actionsFor[index]();
            }
        }

        /// <summary>
        /// This method will show proper behaviour.
        /// </summary>
        public static void TestForeach()
        {
            Console.WriteLine(nameof(TestForeach));

            var actionsForeach = new List<Action>();

            // Each consecutive number (0, 1, 2) is a separate object of type IEnumerable<int> (multiple addresses in memory)
            foreach (var i in Enumerable.Range(0, 3))
            {
                actionsForeach.Add(() => Console.WriteLine(i));
            }

            // Execute all actions
            foreach (var action in actionsForeach)
            {
                action();
            }
        }
    }
}
