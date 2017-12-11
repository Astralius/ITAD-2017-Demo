using System;
using System.Threading.Tasks;

namespace _7.AsyncVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncVoid();
        }

        public async static void AsyncVoid()
        {
            try
            {
                await ThrowExceptionAsync();
            }
            catch (Exception)
            {
                // The exception is never caught here!
                throw;
            }
        }

        private static async Task ThrowExceptionAsync()
        {
            throw new InvalidOperationException();
        }
    }
}
