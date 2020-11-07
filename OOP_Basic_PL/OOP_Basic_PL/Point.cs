using System;

namespace OOP_Basic_PL
{
    public class Point
    {
        private double _x;
        private double _y;
        private enum ReflectionType
        {
            X,
            Y,
            Origin,
        }

        public Point(double x, double y)
        {
            if (x == 0.0)
                throw new Exception("X cannot be null");

            if (y == 0.0)
                throw new Exception("Y cannot be null");

            _x = x;
            _y = y;

        }

        public Point()
        {
            _x = 1.0;
            _y = 1.0;

        }

        public double Distance() => Math.Sqrt((_x * _x) + (_y * _y));

        public double Distance(double x, double y) => Math.Sqrt( Math.Pow( _x - x, 2) + Math.Pow(_y - y, 2));

        public double Distance(double x1, double y1, double x2, double y2) => Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

        public override string ToString() => ($"({_x}, {_y})");
    }
}