using NUnit.Framework;
using MindboxTestTaskLibrary;
using System;

namespace LibraryUnitTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Circle_GetSquare_PositiveRadius_Success()
        {
            double radius = 10;
            double expectedSquare = 314.1592653589793;

            Circle circle = new Circle(radius);
            var square = circle.GetSquare();

            Assert.AreEqual(expectedSquare, square, "Circle calculation error");
        }
        [Test]
        public void Circle_GetSquare_ZeroRadius_Success()
        {
            double radius = 0;
            double expectedSquare = 0;

            Circle circle = new Circle(radius);
            var square = circle.GetSquare();

            Assert.AreEqual(expectedSquare, square, "Circle calculation error");
        }
        [Test]
        public void Circle_GetSquare_NegativeRadius_Fail()
        {
            double radius = -1;

            Assert.Throws<Exception>(() => new Circle(radius), "No such circle exists");
        }
        [TestCase(2, 3, 4)]
        [TestCase(2, 4, 3)]
        [TestCase(3, 2, 4)]
        [TestCase(3, 4, 2)]
        [TestCase(4, 2, 3)]
        [TestCase(4, 3, 2)]
        public void Triangle_GetSquare_VersatileTriangle_Success(double side1, double side2, double side3)
        {
            double expectedSquare = 2.9047375096555625;

            Triangle triangle = new Triangle(side1, side2, side3);
            var square = triangle.GetSquare();

            Assert.AreEqual(expectedSquare,square, "Square calculation error");            
        }
        [TestCase(3, 4, 7)]
        [TestCase(3, 7, 4)]
        [TestCase(7, 3, 4)]
        [TestCase(3.8, 4.7, 8.5)]
        [TestCase(3.8, 8.5, 4.7)]
        [TestCase(8.5, 4.7, 3.8)]
        public void Triangle_GetSquare_EmptyVersatileTriangle_Success(double side1, double side2, double side3)
        {
            double expectedSquare = 0;

            Triangle triangle = new Triangle(side1, side2, side3);
            var square = triangle.GetSquare();

            Assert.AreEqual(expectedSquare, square, "Triangle with empty area calculation error");
        }
        [TestCase(3, 4, 5)]
        [TestCase(3, 5, 4)]
        [TestCase(4, 3, 5)]
        [TestCase(4, 5, 3)]
        [TestCase(5, 3, 4)]
        [TestCase(5, 4, 3)]
        public void Triangle_IsRightTriangle_RightTriangle_Success(double side1, double side2, double side3)
        {
            Triangle triangle = new Triangle(side1, side2, side3);
            var expectedResult = triangle.IsRightTriangle();

            Assert.IsTrue(expectedResult, "Triangle is not right");
        }
        [TestCase(1, 2, 3)]
        [TestCase(3, 3, 3)]
        [TestCase(4.4, 3.3, 5.5)]
        [TestCase(4, 5.5, 3)]
        [TestCase(2.5, 2.5, 5)]
        public void Triangle_IsRightTriangle_VersatileTriangle_Fail(double side1, double side2, double side3)
        {
            Triangle triangle = new Triangle(side1, side2, side3);
            var expectedResult = triangle.IsRightTriangle();

            Assert.IsNotNull(expectedResult, "Triangle is right");
        }
        [TestCase(3, 4, 8)]
        [TestCase(3.2, 9.5, 5.1)]
        [TestCase(16, 1, 1)]
        [TestCase(-8, 5, 4)]
        [TestCase(-6, -9.6, -8.5)]
        [TestCase(-6, 8, -6)]
        [TestCase(2, 0, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, 0, 2)]
        public void Triangle_CheckExistence_VersatileTriangle_Fail(double side1, double side2, double side3)
        {
            Assert.Throws<Exception>(() => new Triangle(side1, side2, side3), "No such triangle exists");
        }        
    }
}