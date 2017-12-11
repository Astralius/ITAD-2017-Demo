using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BoxingValueTypes
{
    internal interface IPoint
    {
        void SetValue(int x, int y);
    }

    internal struct Point : IPoint
    {
        int _x;
        int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void SetValue(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", _x.ToString(), _y.ToString());
        }
    }
}
