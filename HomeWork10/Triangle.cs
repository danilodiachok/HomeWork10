using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    class Triangle
    {
        private Point vertex1;
        private Point vertex2;
        private Point vertex3;

        public Triangle(Point v1, Point v2, Point v3)
        {
            vertex1 = v1;
            vertex2 = v2;
            vertex3 = v3;
        }

        public double Distance(Point p1, Point p2)
        {
            double dx = p1.x - p2.x;
            double dy = p1.y - p2.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public double Perimeter()
        {
            double side1 = Distance(vertex1, vertex2);
            double side2 = Distance(vertex2, vertex3);
            double side3 = Distance(vertex3, vertex1);
            return side1 + side2 + side3;
        }

        public double Square()
        {
            double side1 = Distance(vertex1, vertex2);
            double side2 = Distance(vertex2, vertex3);
            double side3 = Distance(vertex3, vertex1);
            double s = (side1 + side2 + side3) / 2.0;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public void Print()
        {
            Console.WriteLine($"Triangle vertices: {vertex1}, {vertex2}, {vertex3}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
            Console.WriteLine($"Area: {Square()}");
        }

        public double DistanceToOrigin()
        {
            double d1 = Distance(vertex1, new Point(0, 0));
            double d2 = Distance(vertex2, new Point(0, 0));
            double d3 = Distance(vertex3, new Point(0, 0));

            return Math.Min(d1, Math.Min(d2, d3));
        }
    }
}
