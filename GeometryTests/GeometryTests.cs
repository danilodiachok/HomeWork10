using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometryTests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void PointToString_ReturnsCorrectString()
        {
            Point point = new Point(3, 4);

            string result = point.ToString();

            Assert.AreEqual("(3,4)", result);
        }
    }

    
}