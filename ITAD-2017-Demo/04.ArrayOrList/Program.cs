using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ArrayOrList
{
    class Program
    {
        static void Main(string[] args)
        {
            int testSize = 1000 * 1000 * 100; // 100 M

            IEnumerable<int> testSet = Enumerable.Range(0, testSize);

            Console.WriteLine($"Adding {testSize} elements to array");
            MeasureAction(() =>
            {
                var capacity = 1;
                var size = 0;
                var arrayToMeasure = new int[capacity];

                foreach (var testItem in testSet)
                {
                    if (size == arrayToMeasure.Length)
                    {
                        ResizeArray(ref capacity, ref arrayToMeasure);
                    }
                    arrayToMeasure[size++] = testItem;
                }
            });

            Console.WriteLine($"Adding {testSize} elements to list");
            MeasureAction(() =>
            {
                var listToMeasure = new List<int>(1);

                foreach (var testItem in testSet)
                {
                    listToMeasure.Add(testItem);
                }
            });

            Console.ReadKey();
        }

        private static void ResizeArray(ref int capacity, ref int[] arrayToMeasure)
        {
            capacity *= 2;
            var newItems = new int[capacity];
            Array.Copy(arrayToMeasure, 0, newItems, 0, arrayToMeasure.Length);
            arrayToMeasure = newItems;
        }

        private static void MeasureAction(Action action)
        {
            action(); // we call it once beforehand so that JIT can complile it before the measurement

            var stopwatch = Stopwatch.StartNew();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
