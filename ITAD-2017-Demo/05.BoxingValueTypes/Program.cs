using System;

namespace _5.BoxingValueTypes
{
    class Program
    {
        /// <summary>
        /// This example shows risks connected with boxing/unboxing between value types and reference types in C#.
        /// 
        /// Usage:
        /// 0. Set this project as StartUp project.
        /// 1. Write down the values you think each Console.WriteLine call will display.
        /// 2. Start the program (F5). Compare the values with your notes.
        /// 
        /// Explaination: 
        /// Boxing a value type to an object creates a copy of that value type on the heap (i.e. wraps it into an object).
        /// Casting an object onto a value type creates a temporary copy of it ON THE STACK, 
        /// so unless you save it to a variable, it is gone in the next line!
        /// Casting onto an interface is same as casting onto a reference type (the reference is held, no copy is created 
        /// and so, original item is modified).
        /// </summary> 
        static void Main(string[] args)
        {
            Point p = new Point(1, 1);
            Console.WriteLine(p);

            p.SetValue(2, 2);
            Console.WriteLine(p);

            Object o = p;
            Console.WriteLine(o);

            ((Point)o).SetValue(3, 3);
            Console.WriteLine(o);

            ((IPoint)p).SetValue(4, 4);
            Console.WriteLine(p);

            ((IPoint)o).SetValue(5, 5);
            Console.WriteLine(o);

            Console.ReadKey();
        }
    }
}
