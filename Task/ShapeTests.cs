using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AreaCalculator.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void Circle_CalculateArea_CorrectArea()
        {
            // Arrange
            double radius = 5;
            double expectedArea = 78.53981633974483;
            Circle circle = new Circle(radius);

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void Triangle_CalculateArea_CorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void Triangle_IsRightTriangle_RightTriangle()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRightTriangle);
        }

        [Fact]
        public void Triangle_IsRightTriangle_NotRightTriangle()
        {
            // Arrange
            double sideA = 2;
            double sideB = 3;
            double sideC = 4;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.False(isRightTriangle);
        }
    }
}