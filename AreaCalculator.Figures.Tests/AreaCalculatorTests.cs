using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator.Figure.Models;

namespace AreaCalculator.Figures.Tests
{
    [TestClass]
    public class AreaCalculatorTests
    {
        /// <summary>
        /// Отрицательные стороны треугольника выбрасывают исключение
        /// </summary>
        [TestMethod]
        public void NegativeTriangleSidesTest()
        {
            // assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-2, -2, -2));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-2, 0, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, -2, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -2));
        }
        /// <summary>
        /// Отрицательный радиус окружности выбрасывают исключение
        /// </summary>
        [TestMethod]
        public void NegativeCircleRadiusTest()
        {
            // assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-2));
        }
        /// <summary>
        /// Площадь окружности
        /// </summary>
        [TestMethod]
        public void AreaCircleCalculateTest()
        {
            // arrange
            Circle circle = new Circle(2);

            // act
            double circleArea = circle.Area;

            // assert
            Assert.AreEqual(12.566370614359173, circleArea);
        }
        /// <summary>
        /// Площадь треугольника
        /// </summary>
        [TestMethod]
        public void AreaTriangleCalculateTest()
        {
            // arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // act
            double triangleArea = triangle.Area;

            // assert
            Assert.AreEqual(6, triangleArea);
        }
        /// <summary>
        /// Треугольник прямоугольный
        /// </summary>
        [TestMethod]
        public void RightAngleTriangleTest()
        {
            // arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // act
            bool isTriangleRectangular = triangle.IsRectangular;

            // assert
            Assert.AreEqual(true, isTriangleRectangular);
        }

        /// <summary>
        /// Треугольник не прямоугольный
        /// </summary>
        [TestMethod]
        public void NotRightAngleTriangleTest()
        {
            // arrange
            Triangle triangle = new Triangle(3, 5, 1);

            // act
            bool isTriangleRectangular = triangle.IsRectangular;

            // assert
            Assert.AreEqual(false, isTriangleRectangular);
        }
    }
}
