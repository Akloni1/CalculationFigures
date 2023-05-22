using CalculationFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculationFigures
{
    public class TriangleTest
    {
        [Fact]
        public void TestAreaIntSides()
        {
            // Arrange
            IFigure triangle = new Triangle(7, 7, 7);

            // Act
            double result = triangle.Area();

            // Assert
            Assert.Equal(21.21762239271875, result);
        }

        [Fact]
        public void TestAreaDoubleSides()
        {
            // Arrange
            IFigure triangle = new Triangle(4.476, 7.2435, 9.3245);

            // Act
            double result = triangle.Area();

            // Assert
            Assert.Equal(15.803692659376953, result);
        }

        [Fact]
        public void TestAreaZeroSides()
        {
            // Arrange
            IFigure triangle = new Triangle(0, 0, 0);

            // Assert
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        [Fact]
        public void TestAreaNegativeSides()
        {
            // Arrange
            IFigure triangle = new Triangle(-3, -5, -4);

            // Assert
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        [Fact]
        public void TestAreaNegativeAndIntSides()
        {
            // Arrange
            IFigure triangle = new Triangle(-3, 5, 4);

            // Assert
            Assert.Throws<ArgumentException>(() => triangle.Area());

        }


        [Fact]
        public void TestIsRightTriangleTrue()
        {
            // Arrange
            ITriangle triangle = new Triangle(3, 5, 4);

            // Act
            bool result = triangle.IsRightTriangle();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestIsRightTriangleFalse()
        {
            // Arrange
            ITriangle triangle = new Triangle(3, 9, 9);

            // Act
            bool result = triangle.IsRightTriangle();

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void TestIsRightTriangleThrow()
        {
            // Arrange
            ITriangle triangle = new Triangle(-1.996, 9, 0);

            // Assert
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }
    }
}
