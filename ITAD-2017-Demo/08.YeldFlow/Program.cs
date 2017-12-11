using System;
using System.Collections.Generic;

namespace _8.YeldFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> elements = CreateElements("ABC");
            try
            {
                foreach (int element in elements)
                {
                    if (element == 'A')
                    {
                        Console.WriteLine("A");
                    }
                    if (element == 'B')
                    {
                        CreateElements(null);
                    }
                    if (element == 'C')
                    {
                        Console.WriteLine("C");
                        throw new ApplicationException();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("E");
            }
            Console.ReadKey();
        }

        public static IEnumerable<int> CreateElements(string input)
        {
            try
            {
                if (input == null)
                {
                    Console.WriteLine("B");
                }
                foreach (int c in input)
                {
                    yield return c;
                }
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
}
