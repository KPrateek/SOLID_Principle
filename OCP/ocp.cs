using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class OCP
    {
        public abstract class Shape
        {
            public abstract double Area();
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public override double Area()
            {
                return Width*Height;
            }
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            public override double Area()
            {
                return Radius*Radius*Math.PI;
            }
        }

        public class Triangle : Shape
        {
            public double Base { get; set; }
            public double Height { get; set; }

            public override double Area()
            {
                return 0.5*Base*Height;
            }
        }

        public void CalculateArea(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Area();
                Console.WriteLine(shape.Area());
            }
        }

        private static void Main(string[] args)
        {
            OCP ocp = new OCP();
            List<Shape> shapes = new List<Shape>();

            Circle circle = new Circle();
            circle.Radius = 5.0;
            shapes.Add(circle);

            Rectangle rectangle = new Rectangle();
            rectangle.Height = 10;
            rectangle.Width = 20;
            shapes.Add(rectangle);

            Triangle triangle = new Triangle();
            triangle.Base = 30;
            triangle.Height = 20;
            shapes.Add(triangle);

            ocp.CalculateArea(shapes);

        }
    }

}
