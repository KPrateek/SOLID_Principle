using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NON_OCP_Example
{
    class NonOCP
    {
        /// <summary>
        /// Non OCP with area calculation for many rectangle shapes
        /// </summary>
        public class Rectangle
        {
            public double Width { get; set; }
            public double Height { get; set; }
        }



        public class AreaCalculator
        {
            public double Area(Rectangle[] shapes)
            {
                double area = 0;
                foreach (var shape in shapes)
                {
                    area += shape.Width * shape.Height;
                    Console.WriteLine(area);
                    area = 0;
                }

                return area;
            }
        }


        //static void Main(string[] args)
        //{
        //    Rectangle[] rect1 = new Rectangle[2];

        //    rect1[0] = new Rectangle();
        //    rect1[0].Height = 2;
        //    rect1[0].Width = 3;

        //    rect1[1] = new Rectangle();
        //    rect1[1].Height = 5;
        //    rect1[1].Width = 4;

        //    AreaCalculator rectArea = new AreaCalculator();
        //    rectArea.Area(rect1);

        //}
        //////////////////////////////////////////////////////////////////



        /// <summary>
        /// Non OCP with area calculation for many shapes
        /// </summary>

        //public class Rectangle
        //{
        //    public double Width { get; set; }
        //    public double Height { get; set; }
        //}


        //public class Circle
        //{
        //    public double Radius { get; set; }
        //}

        //public class Triangle
        //{
        //    public double Height { get; set; }
        //    public double Base { get; set; }
        //}

        //public class AreaCalculator
        //{
        //    public double Area(List<object> shapes)
        //    {
        //        double area = 0;
        //        foreach (var shape in shapes)
        //        {
        //            if (shape is Rectangle)
        //            {
        //                Rectangle rectangle = (Rectangle) shape;
        //                area += rectangle.Width*rectangle.Height;
        //            }
        //            else if (shape is Circle)
        //            {
        //                Circle circle = (Circle) shape;
        //                area += circle.Radius*circle.Radius*Math.PI;
        //            }
        //            else if (shape is Triangle)
        //            {
        //                Triangle triangle = (Triangle) shape;
        //                area += 0.5*triangle.Base*triangle.Height;
        //            }
        //            Console.WriteLine(area);
        //            area = 0;
        //        }
        //        return area;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Rectangle[] rect1 = new Rectangle[2];
        //    List<object> listShapes= new List<object>();

        //    rect1[0] = new Rectangle();
        //    rect1[0].Height = 2;
        //    rect1[0].Width = 3;
        //    listShapes.Add(rect1[0]);

        //    rect1[1] = new Rectangle();
        //    rect1[1].Height = 5;
        //    rect1[1].Width = 4;
        //    listShapes.Add(rect1[1]);

        //    Circle circle = new Circle();
        //    circle.Radius = 10;
        //    listShapes.Add(circle);

        //    Triangle triangle = new Triangle();
        //    triangle.Height = 20;
        //    triangle.Base = 10;
        //    listShapes.Add(triangle);


        //    AreaCalculator shapeAreaCalculator = new AreaCalculator();
        //    shapeAreaCalculator.Area(listShapes);
        //}
        ///////////////////////////////////////////////////////////////////////
    }
}
