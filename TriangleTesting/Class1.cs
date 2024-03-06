using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using TriangleSolver;

namespace TriangleTests
{
    [TestFixture]
    public class TriangleTesting
    {
        [Test]
        public void AnalyzeTriangle_ValidEquilateral()
        {
            // Arrange
            int side1 = 5;
            int side2 = 5;
            int side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
           ClassicAssert.AreEqual("Equilateral triangle", result);
        }

    }
}
