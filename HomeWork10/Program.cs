namespace HomeWork10
{
    using System;
    using System.Collections.Generic;

    struct Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }
    }


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the coordinates for Point 1 (x y):");
            string[] input = Console.ReadLine().Split();
            Point point1 = new Point(double.Parse(input[0]), double.Parse(input[1]));

            Console.WriteLine("Enter the coordinates for Point 2 (x y):");
            input = Console.ReadLine().Split();
            Point point2 = new Point(double.Parse(input[0]), double.Parse(input[1]));

            Console.WriteLine("Enter the coordinates for Point 3 (x y):");
            input = Console.ReadLine().Split();
            Point point3 = new Point(double.Parse(input[0]), double.Parse(input[1]));

            Console.WriteLine("Enter the coordinates for Point 4 (x y):");
            input = Console.ReadLine().Split();
            Point point4 = new Point(double.Parse(input[0]), double.Parse(input[1]));

            Console.WriteLine("Enter the coordinates for Point 5 (x y):");
            input = Console.ReadLine().Split();
            Point point5 = new Point(double.Parse(input[0]), double.Parse(input[1]));

            Triangle triangle1 = new Triangle(point1, point2, point3);
            Triangle triangle2 = new Triangle(point2, point3, point4);
            Triangle triangle3 = new Triangle(point3, point4, point5);

            List<Triangle> triangles = new List<Triangle> { triangle1, triangle2, triangle3 };



            // Find the triangle closest to the origin
            Triangle closestToOrigin = triangles[0];
            foreach (var triangle in triangles)
            {
                if (triangle.DistanceToOrigin() < closestToOrigin.DistanceToOrigin())
                {
                    closestToOrigin = triangle;
                }
            }

            Console.WriteLine("Information about the triangles:");
            foreach (var triangle in triangles)
            {
                triangle.Print();
                Console.WriteLine();
            }

            Console.WriteLine("Triangle closest to the origin: ");
            closestToOrigin.Print();
        }
    }
}