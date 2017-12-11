using System;

namespace _5.BoxingValueTypes
{
    class Program
    {
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
        }
    }
}
