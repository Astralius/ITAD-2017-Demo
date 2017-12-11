namespace _5.BoxingValueTypes
{
    internal interface IPoint
    {
        void SetValue(int x, int y);
    }

    internal struct Point : IPoint
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void SetValue(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", X.ToString(), Y.ToString());
        }
    }
}
