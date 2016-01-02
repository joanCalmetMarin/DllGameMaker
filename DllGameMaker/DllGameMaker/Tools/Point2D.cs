using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllGameMaker
{
    /// <summary>
    /// Point 2D 
    /// </summary>
    public class Point2D
    {
        private double _x; // double who simbolize X
        private double _y; // double who simbolize Z

        /// <summary>
        /// Get and set for X
        /// </summary>
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Get and set for Y
        /// </summary>
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// constructor void set point on 0,0
        /// </summary>
        public Point2D()
        {
            _x = _y = 0;
        }
        
        /// <summary>
        /// constructor with x and y
        /// </summary>
        /// <param name="x">double where is x</param>
        /// <param name="y">double where is y</param>
        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }

        /// <summary>
        /// constructor with other point
        /// </summary>
        /// <param name="other">other point2D</param>
        public Point2D(Point2D other)
        {
            _x = other.X;
            _y = other.Y;
        }

        /// <summary>
        /// Calculate de distance to the other point 
        /// </summary>
        /// <param name="other">other point 2d</param>
        /// <returns>distance by pitagoras</returns>
        public double DistanceTo(Point2D other)
        {
            var x = _x - other.X;
            var y = _y - other.Y;
            return (Math.Sqrt(x*x+y*y)); //Math.Sqrt it's the same as make ¿square root?
        }

        /// <summary>
        /// override of equals
        /// </summary>
        /// <param name="obj">other 2dPoint</param>
        /// <returns>true if they are the same values</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            var point = obj as Point2D;
            if (point == null) return false;

            return (_x == point.X && _y == point.Y);
        }

        /// <summary>
        /// operation of override the operator ==
        /// </summary>
        /// <param name="a">point 2d</param>
        /// <param name="b">point 2d</param>
        /// <returns>return true if the both are equals</returns>
        public static bool operator ==(Point2D a,Point2D b)
        {
            if (a == null || b == null) return false;
            return a.Equals(b);
        }

        /// <summary>
        /// operation of override the operator !=
        /// </summary>
        /// <param name="a">point 2d</param>
        /// <param name="b">point 2d</param>
        /// <returns>return true if the both are equals</returns>
        public static bool operator !=(Point2D a, Point2D b)
        {
            return !(a == b);
        }

        /// <summary>
        /// override the operator +
        /// </summary>
        /// <param name="a">point 2d</param>
        /// <param name="b">point 2d</param>
        /// <returns>new point 2d</returns>
        public static Point2D operator +(Point2D a, Point2D b)
        {
            if (a == null || b == null) return new Point2D();
            return new Point2D(a.X + b.X, a.Y + b.Y);
        }

        /// <summary>
        /// override the operator -
        /// </summary>
        /// <param name="a">point 2d</param>
        /// <param name="b">point 2d</param>
        /// <returns>new point 2d</returns>
        public static Point2D operator -(Point2D a, Point2D b)
        {
            if (a == null || b == null) return new Point2D();
            return new Point2D(a.X - b.X, a.Y - b.Y);
        }
    }
}
