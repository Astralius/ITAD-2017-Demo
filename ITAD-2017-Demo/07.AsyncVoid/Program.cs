using System;
using System.Threading.Tasks;

namespace _7.AsyncVoid
{
    class Program
    {
        /// <summary>
        /// This example shows that you should definitely avoid using async void methods.
        /// 
        /// Usage:
        /// 0. Set this project as StartUp project.
        /// 1. Start the program (F5). Notice that the exception is not caught in the try-catch block!
        /// 2. Stop the program. 
        /// 3. Comment line 34, uncomment line 35.
        /// 4. Start the program again. Notice that the exception is now caught properly (execution stops in the catch block, as expected.).
        /// 
        /// Explaination:
        /// Calling async void method causes the execution flow of the calling code to continue 
        /// (the method returns nothing, so nothing can be awaited and we cannot intercept the state of execution of the async void method.).
        /// Contary to the above, specyfing Task as return value allows us to await the result. The returned object will contain information 
        /// about the result OR any exception thrown, allowing us to catch the exception in the catch block.
        /// </summary> 
        static void Main(string[] args)
        {
            CatchException();
            Console.ReadKey();
        }

        public static async void CatchException()
        {
            try
            {
                ThrowExceptionAsyncWrongly();
                //await ThrowExceptionAsyncCorrectly();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static async void ThrowExceptionAsyncWrongly()
        {
            // below exeption will not be caught! :(
            throw new InvalidOperationException();
        }

        private static async Task ThrowExceptionAsyncCorrectly()
        {
            // below exception WILL be caught! :)
            throw new InvalidOperationException();
        }
    }
}
