using CalculationFigures;

namespace TestCalculationFigures
{
    public class CircleTest
    {
        [Fact]
        public void TestAreaIntRadius()
        {
            // Arrange
            IFigure circle = new Circle(5);

            // Act
            double result = circle.Area();

            // Assert
            Assert.Equal(78.53975, result);
        }

        [Fact]
        public void TestAreaDoubleRadius()
        {
            // Arrange
            IFigure circle = new Circle(12.2459870);

            // Act
            double result = circle.Area();

            // Assert
            Assert.Equal(471.12602355128126, result);
        }

        [Fact]
        public void TestAreaNegativeRadius()
        {
            // Arrange
            IFigure circle = new Circle(-8);

            // Assert
            Assert.Throws<ArgumentException>(() => circle.Area());
        }


        [Fact]
        public void TestAreaZeroRadius()
        {
            // Arrange
            IFigure circle = new Circle(0);

            // Assert
            Assert.Throws<ArgumentException>(() => circle.Area());
        }
    }
}


