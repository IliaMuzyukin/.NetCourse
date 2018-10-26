using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set { if(value>0)a = value; }
        }
        public double B
        {
            get { return b; }
            set { if (value > 0) b = value; }
        }
        public double C
        {
            get { return c; }
            set { if (value > 0) { c = value; } }
        }
        public double Square(Triangle triangle)
        {
            double p = triangle.Perimetr(triangle)/2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public Triangle(double a, double b, double c)
        {
            if ((a < 0) || (b < 0) || (c < 0))
            {
                throw new ArgumentOutOfRangeException("Line of triangle can't be less or equality 0");
            }
            else if ((b + c > a) && (a + c > b) && (a + b > c))
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new ArgumentException($"Values {a}, {b}, {c} don't form a triangle");
            }
           
        }
        public double Perimetr(Triangle triangle)
        {
            return a + b + c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(2, 2, 4);
            triangle.Perimetr(triangle);
            Console.WriteLine("Perimetr: {0}", triangle.Perimetr(triangle));
            Console.WriteLine("Square: {0}", triangle.Square(triangle));
            Console.ReadLine();
        }
    }
}
