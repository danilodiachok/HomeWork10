using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TrianglePerimeter_CalculatesCorrectPerimeter()
        {
           
            Point v1 = new Point(0, 0);
            Point v2 = new Point(3, 0);
            Point v3 = new Point(0, 4);
            Triangle triangle = new Triangle(v1, v2, v3);

          
            double result = triangle.Perimeter();

        
            Assert.AreEqual(12.0, result);
        }

        [TestMethod]
        public void TriangleSquare_CalculatesCorrectArea()
        {
            
            Point v1 = new Point(0, 0);
            Point v2 = new Point(3, 0);
            Point v3 = new Point(0, 4);
            Triangle triangle = new Triangle(v1, v2, v3);

           
            double result = triangle.Square();

         
            Assert.AreEqual(6.0, result);
        }
    }
}
