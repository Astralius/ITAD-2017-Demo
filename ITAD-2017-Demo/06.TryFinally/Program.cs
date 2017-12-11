using System;
using System.Text;

namespace _6.TryFinally
{
    class Program
    {
        /// <summary>
        /// This example shows that:
        /// 1. You should avoid modifying the returned value in the finally block.
        /// 2. You should avoid using multiple return statements.
        /// 
        /// Usage:
        /// 0. Set this project as StartUp project.
        /// 1. Write down what you think will be result to the 3 methods calls below (TestFlow1 to 3).
        /// 2. Run the program (F5). Inspect the returned values (hit any key to go to the result of the next method).
        /// 
        /// Explaination: 
        /// The finally block is always executed (regardless if any exception was thrown). 
        /// Returned value (or address/reference) is saved on the STACK, with scope lifetime. That's why calling return on a value type 
        /// in the finally block will have no effect (returned value is already fixed) (TestFlow2). 
        /// Modifying the value inside a reference type though is allowed, because only the address is fixed (you can't return 
        /// another object, but you can modify its state and the returned object will reflect this modification) (TestFlow3). 
        /// Return statement used beyond the scope of the first return statement (TestFlow1) overrides the first return statement.
        /// </summary> 
        static void Main(string[] args)
        {
            int result1 = Program.TestFlow1();
            Console.WriteLine($"Result 1: {result1}");

            Console.ReadKey(true);
            Console.WriteLine();

            int result2 = Program.TestFlow2(1, 2);
            Console.WriteLine($"Result 2: {result2}");

            Console.ReadKey(true);
            Console.WriteLine();

            StringBuilder result3 = TestFlow3("first", "second");
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
                    return 1;   // scope of this return statement is the inner try-finally block.
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
                return 2;   // scope of this return statement is the outer try-catch block. This will override the inner return statement.
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
