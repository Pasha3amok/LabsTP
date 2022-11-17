using NUnit.Framework;
using System.IO;

namespace ShapesLib.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTriangle()
        {
            var triangle = new Triangle(new Point(2, 10), new Point(0, 0), new Point(4, 0));

            Assert.AreEqual(triangle.A, new Point(2, 10));
            Assert.AreEqual(triangle.B, new Point(0, 0));
            Assert.AreEqual(triangle.C, new Point(4, 0));
            Assert.AreEqual(triangle.GetArea(), 20);
            Assert.AreEqual(triangle.GetPerimeter(), 24.4);
            Assert.AreEqual(triangle.ToString(), "Triangle A(2;10), B(0;0), C(4;0); Area is 20; Perimeter is 24,4.");
        }

        [Test]
        public void TestEquilateralTriangle()
        {
            var equilateralTriangle = new EquilateralTriangle(new Point(1, -5), new Point(-1, 0), new Point(3, 0));

            Assert.AreEqual(equilateralTriangle.A, new Point(1, -5));
            Assert.AreEqual(equilateralTriangle.B, new Point(-1, 0));
            Assert.AreEqual(equilateralTriangle.C, new Point(3, 0));
            Assert.AreEqual(equilateralTriangle.GetArea(), 12, 56);
            Assert.AreEqual(equilateralTriangle.GetPerimeter(), 16, 16);
            Assert.AreEqual(equilateralTriangle.ToString(), "EquilateralTriangle A(1;-5), B(-1;0), C(3;0); Area is 12,56; Perimeter is 16,16.");
        }

        [Test]
        public void TestRectangle()
        {
            var rectangle = new Rectangle(new Point(6, 1), new Point(6, 5), new Point(3, 5), new Point(3, 1));

            Assert.AreEqual(rectangle.A, new Point(6, 1));
            Assert.AreEqual(rectangle.B, new Point(6, 5));
            Assert.AreEqual(rectangle.C, new Point(3, 5));
            Assert.AreEqual(rectangle.D, new Point(3, 1));
            Assert.AreEqual(rectangle.GetArea(), 12);
            Assert.AreEqual(rectangle.GetPerimeter(), 11);
            Assert.AreEqual(rectangle.ToString(), "Rectangle A(6;1), B(6;5), C(3;5), D(3;1); Area is 12; Perimeter is 11.");
        }

        [Test]
        public void TestSquare()
        {
            var square = new Square(new Point(4, -6), new Point(4, 4), new Point(-6, 4), new Point(-6, -6));

            Assert.AreEqual(square.A, new Point(4, -6));
            Assert.AreEqual(square.B, new Point(4, 4));
            Assert.AreEqual(square.C, new Point(-6, 4));
            Assert.AreEqual(square.D, new Point(-6, -6));
            Assert.AreEqual(square.GetArea(), 100);
            Assert.AreEqual(square.GetPerimeter(), 40);
            Assert.AreEqual(square.ToString(), "Square A(4;-6), B(4;4), C(-6;4), D(-6;-6); Area is 100; Perimeter is 40.");
        }

        [Test]
        public void TestRhomb()
        {
            var rhomb = new Rhomb(new Point(-4, 0), new Point(0, 6), new Point(4, 0), new Point(0, -6));

            Assert.AreEqual(rhomb.A, new Point(-4, 0));
            Assert.AreEqual(rhomb.B, new Point(0, 6));
            Assert.AreEqual(rhomb.C, new Point(4, 0));
            Assert.AreEqual(rhomb.D, new Point(0, -6));
            Assert.AreEqual(rhomb.GetArea(), 48);
            Assert.AreEqual(rhomb.GetPerimeter(), 28, 84);
            Assert.AreEqual(rhomb.ToString(), "Rhomb A(-4;0), B(0;6), C(4;0), D(0;-6); Area is 48; Perimeter is 28,84.");
        }
        [Test]
        public void TestCircle()
        {
            var circle = new Circle(new Point(0, 0), new Point(3, 0));

            Assert.AreEqual(circle.O, new Point(0, 0));
            Assert.AreEqual(circle.A, new Point(3, 0));
            Assert.AreEqual(circle.GetArea(), 28, 27);
            Assert.AreEqual(circle.GetPerimeter(), 18, 85);
            Assert.AreEqual(circle.ToString(), "Circle Center O(0;0), Random point A(3;0); Area is 28,27; Perimeter is 18,85.");
        }

        [Test]
        public void TestEllipse()
        {
            var ellipse = new Ellipse(new Point(0, 0), new Point(5, 0), new Point(0, 3));

            Assert.AreEqual(ellipse.O, new Point(0, 0));
            Assert.AreEqual(ellipse.A, new Point(5, 0));
            Assert.AreEqual(ellipse.B, new Point(0, 3));
            Assert.AreEqual(ellipse.GetArea(), 47, 12);
            Assert.AreEqual(ellipse.GetPerimeter(), 25, 91);
            Assert.AreEqual(ellipse.ToString(), "Ellipse Center O(0;0), Major Axis A(5;0), Minor Axis B(0;3); Area is 47,12; Perimeter is 25,91.");
        }

        [Test]
        public void TestPoint()
        {
            var point = new Point(-28, 56);
            Assert.AreEqual(point.X, -28);
            Assert.AreEqual(point.Y, 56);
            Assert.AreEqual(point.ToString(), "(-28;56)");
        }

        [Test]
        public void TestMethodsInShapeOption()
        {
            // Тест на правильну кількість фігур
            var testParam = ShapeOption.GetParam("C:\\Users\\pasha\\Documents\\2 year\\ProgrammingTechnology\\Lab2\\shapeseducationproject-main\\ShapesConsoleUI\\param.txt");
            Assert.AreEqual(int.Parse(testParam[0][0]) + 1, testParam.Count);

            var testShapeTriangle = ShapeOption.CreateShapes(testParam, 1);
            var testShapeRectangle = ShapeOption.CreateShapes(testParam, 5);
            var testShapeEllipse = ShapeOption.CreateShapes(testParam, 7);

            Assert.AreEqual(new Triangle(new Point(2, 10), new Point(0, 0), new Point(4, 0)), testShapeTriangle);
            Assert.AreEqual(new Rectangle(new Point(6, 1), new Point(6, 5), new Point(3, 5), new Point(3, 1)), testShapeRectangle);
            Assert.AreEqual(new Ellipse(new Point(0, 0), new Point(5, 0), new Point(0, 3)), testShapeEllipse);
        }

        [Test]
        public void TestFile()
        {
            var strContent = string.Empty;
            using (var file = new StreamReader("C:\\Users\\pasha\\Documents\\2 year\\ProgrammingTechnology\\Lab2\\shapeseducationproject-main\\ShapesConsoleUI\\param.txt"))
                strContent = file.ReadToEnd();
            System.Console.WriteLine(strContent);
            Assert.AreEqual(strContent, "7;" +
                                        "\r\nTriangle 2 10 0 0 4 0;" +
                                        "\r\nSquare 4 -6 4 4 -6 4 -6 -6;" +
                                        "\r\nRhomb -4 0 0 6 4 0 0 -6;" +
                                        "\r\nEquilateralTriangle 1 -5 -1 0 3 0;" +
                                        "\r\nRectangle 6 1 6 5 3 5 3 1;" +
                                        "\r\nCircle 0 0 3 0;" +
                                        "\r\nEllipse 0 0 5 0 0 3;");
        }

        [Test]
        public void TestGetSide()
        {
            var testSide = Shape.GetSide(new Point(4, -6), new Point(-6, -6));
            var testSide2 = Shape.GetSide(new Point(8, -12), new Point(-12, -12));

            Assert.AreEqual(10, testSide);
            Assert.AreEqual(20, testSide2);
        }
            [Test]
        public void DeboObject_ToString_ReturnsCorrectValue()
        {
            var obj = new DemoClass();
            Assert.AreEqual(obj.ToString(), "I am object of demo class that defined in ShapesLib project");
        }
    }
}