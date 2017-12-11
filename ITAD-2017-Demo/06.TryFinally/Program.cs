using System;
using System.Text;

namespace _6.TryFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = TestFlow1();
            Console.WriteLine($"Result 1: {result1}");
            Console.ReadKey();
            Console.WriteLine();

            var result2 = TestFlow2(1, 2);
            Console.WriteLine($"Result 2: {result2}");
            Console.ReadKey();
            Console.WriteLine();

            var result3 = TestFlow3("first", "second");
            Console.WriteLine($"Result 3: {result3}");
            Console.ReadKey();
        }

        public static int TestFlow1()
        {
            try
            {
                try
                {
                    Console.WriteLine('A');
                    return 1;
                }
                finally
                {
                    Console.WriteLine('B');
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine('C');
                return 2;
            }
        }

        public static int TestFlow2(int first, int second)
        {
            var result = first;
            try
            {
                Console.WriteLine('A');
                return result;
            }
            finally
            {
                Console.WriteLine('B');
                result = second;
            }
        }

        public static StringBuilder TestFlow3(string first, string second)
        {
            var result = new StringBuilder(first);
            try
            {
                Console.WriteLine('A');
                return result;
            }
            finally
            {
                Console.WriteLine('B');
                result.Length = 0;
                result.Append(second);
            }
        }
    }
}
