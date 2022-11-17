using System;
using System.Collections.Generic;
using System.IO;

namespace ShapesLib
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();

        public static double GetSide(Point pointA, Point pointB)
        {
            return Math.Sqrt(Math.Pow(pointA.X - pointB.X, 2) + Math.Pow(pointA.Y - pointB.Y, 2));
        }
    }

    public class ShapeOption
    {
        public static List<string[]> GetParam(string filename)
        {
            var fileContent = File.ReadAllText(filename);
            var arrayContent = fileContent.Split(";");
            var param = new List<string[]>();
            foreach (var content in arrayContent)
                if(content == "")
                    continue;
                else
                    param.Add(content.Split(" "));
            return param;
        }

        public static Shape CreateShapes(List<string[]> content, int numberOfShape)
        {
            for (int i = numberOfShape; i < int.Parse(content[0][0])+1; i++)
            {
                var shape = content[i][0].Trim();
                switch (shape)
                {
                    case "Triangle": 
                        {
                            var A = new Point(double.Parse(content[i][1]), double.Parse(content[i][2]));
                            var B = new Point(double.Parse(content[i][3]), double.Parse(content[i][4]));
                            var C = new Point(double.Parse(content[i][5]), double.Parse(content[i][6])); 
                            return new Triangle(A, B, C);
                        }
                    case "Square": 
                        {
                            var A = new Point(double.Parse(content[i][1]), double.Parse(content[i][2]));
                            var B = new Point(double.Parse(content[i][3]), double.Parse(content[i][4]));
                            var C = new Point(double.Parse(content[i][5]), double.Parse(content[i][6]));
                            var D = new Point(double.Parse(content[i][7]), double.Parse(content[i][8]));
                            return new Square(A, B, C, D);
                        }
                    case "Rhomb":
                        {
                            var A = new Point(double.Parse(content[i][1]), double.Parse(content[i][2]));
                            var B = new Point(double.Parse(content[i][3]), double.Parse(content[i][4]));
                            var C = new Point(double.Parse(content[i][5]), double.Parse(content[i][6]));
                            var D = new Point(double.Parse(content[i][7]), double.Parse(content[i][8]));
                            return new Rhomb(A, B, C, D);
                        }
                    case "EquilateralTriangle":
                        {
                            var A = new Point(double.Parse(content[i][1]), double.Parse(content[i][2]));
                            var B = new Point(double.Parse(content[i][3]), double.Parse(content[i][4]));
                            var C = new Point(double.Parse(content[i][5]), double.Parse(content[i][6]));
                            return new EquilateralTriangle(A, B, C);
                        }
                    case "Rectangle":
                        {
                            var A = new Point(double.Parse(content[i][1]), double.Parse(content[i][2]));
                            var B = new Point(double.Parse(content[i][3]), double.Parse(content[i][4]));
                            var C = new Point(double.Parse(content[i][5]), double.Parse(content[i][6]));
                            var D = new Point(double.Parse(content[i][7]), double.Parse(content[i][8]));
                            return new Rectangle(A, B, C, D);
                        }
                    case "Circle":
                        {
                            var A = new Point(double.Parse(content[i][1]), double.Parse(content[i][2]));
                            var B = new Point(double.Parse(content[i][3]), double.Parse(content[i][4]));
                            return new Circle(A, B);
                        }
                    case "Ellipse":
                        {
                            var O = new Point(double.Parse(content[i][1]), double.Parse(content[i][2]));
                            var A = new Point(double.Parse(content[i][3]), double.Parse(content[i][4]));
                            var B = new Point(double.Parse(content[i][5]), double.Parse(content[i][6]));
                            return new Ellipse(O,A,B);
                        }
                }       
            }
            return null;

        }

    }

    public class Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return string.Format($"({X};{Y})");
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point p = (Point)obj;
                return (X == p.X) && (Y == p.Y);
            }
        }
    }

    public abstract class Polygons : Shape
    {
        public Point A;
        public Point B;
        public Point C;
        public Point D;
    }

    public class Triangle : Polygons
    {

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            return Math.Abs(((B.X - A.X) * (C.Y - A.Y) - (C.X - A.X) * (B.Y - A.Y)) / 2);
        }
        public override double GetPerimeter()
        {
            return Math.Round(GetSide(A, B) + GetSide(B, C) + GetSide(C, A), 2);
        }

        public override string ToString()
        {
            return string.Format($"Triangle A{A}, B{B}, C{C}; Area is {GetArea()}; Perimeter is {GetPerimeter()}.");
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Triangle t = (Triangle)obj;
                return ToString() == t.ToString();
            }

        }
    }

    public class EquilateralTriangle: Polygons
    {
        public EquilateralTriangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double GetArea()
        {
            return Math.Round(Math.Sqrt(3)/4*Math.Pow(GetSide(A,B),2),2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(3 *GetSide(A,B),2);
        }
        public override string ToString()
        {
            return string.Format($"EquilateralTriangle A{A}, B{B}, C{C}; Area is {GetArea()}; Perimeter is {GetPerimeter()}.");
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                EquilateralTriangle et = (EquilateralTriangle)obj;
                return ToString() == et.ToString();
            }

        }
    }

    public class Rectangle: Polygons
    {
        public Rectangle(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public override double GetArea()
        {
            return Math.Round(GetSide(A,B)*GetSide(B,C),2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * GetSide(A, B) + GetSide(B, C), 2);
        }
        public override string ToString()
        {
            return string.Format($"Rectangle A{A}, B{B}, C{C}, D{D}; Area is {GetArea()}; Perimeter is {GetPerimeter()}.");
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Rectangle rec = (Rectangle)obj;
                return ToString() == rec.ToString();
            }

        }
    }

    public class Square : Polygons
    {

        public Square(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public override double GetArea()
        {
            return Math.Round(Math.Pow(GetSide(A, D), 2),2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(GetSide(A, D) * 4 ,2);
        }
        public override string ToString()
        {
            return string.Format($"Square A{A}, B{B}, C{C}, D{D}; Area is {GetArea()}; Perimeter is {GetPerimeter()}.");
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Square sq = (Square)obj;
                return ToString() == sq.ToString();
            }

        }
    }
    public class Rhomb : Polygons
    {

        public Rhomb(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public override double GetArea()
        {
        return Math.Round(Math.Abs(GetSide(A, C) * GetSide(B, D) / 2),2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * Math.Sqrt(Math.Pow(GetSide(A, C),2) + Math.Pow(GetSide(B, D),2)),2);
        }
        public override string ToString()
        {
            return string.Format($"Rhomb A{A}, B{B}, C{C}, D{D}; Area is {GetArea()}; Perimeter is {GetPerimeter()}.");
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Rhomb rh = (Rhomb)obj;
                return ToString() == rh.ToString();
            }

        }
    }
    public class Circle: Shape
    {
        public Point O; //Center
        public Point A; 

        public Circle(Point o, Point a) 
        { 
            O = o;
            A = a;
        }

        public override double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(GetSide(O,A),2),2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * GetSide(O,A) * Math.PI,2);
        }
        public override string ToString()
        {
            return string.Format($"Circle Center O{O}, Random point A{A}; Area is {GetArea()}; Perimeter is {GetPerimeter()}.");
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Circle O = (Circle)obj;
                return ToString() == O.ToString();
            }

        }
    }

    public class Ellipse: Shape
    {
        public Point O; //Center
        public Point A; //Major Axis
        public Point B; //Minor Axis

        public Ellipse(Point o, Point a, Point b)
        {
            O = o;
            A = a;
            B = b;
        }

        public override double GetArea()
        {
            return Math.Round(Math.PI * GetSide(O,A) * GetSide(O,B),2);
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * Math.PI * Math.Sqrt( (Math.Pow(GetSide(O,A),2) + Math.Pow(GetSide(O,B),2))/2),2);
        }

        public override string ToString()
        {
            return string.Format($"Ellipse Center O{O}, Major Axis A{A}, Minor Axis B{B}; Area is {GetArea()}; Perimeter is {GetPerimeter()}.");
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Ellipse ell = (Ellipse)obj;
                return ToString() == ell.ToString();
            }

        }
    }

 
}
