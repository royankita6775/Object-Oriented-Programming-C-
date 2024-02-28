using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static task_42.Shape;

namespace task_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle()
            {
                Name = "Circle",
                Radius = 1,
                Area = 3.14,
                Circumference = 7.28
            };
            Circle circle2 = new Circle()
            {
                Name = "Circle",
                Radius = 2,
                Area = 12.57,
                Circumference = 12.56
            };
            Circle circle3 = new Circle()
            {
                Name = "Circle",
                Radius = 3,
                Area = 28.27,
                Circumference = 18.84
            };
            Rectangle rectangle1 = new Rectangle()
            {
                Name = "Rectangle",
                Width = 10,
                Height = 20,
                Area = 200.00,
                Circumference = 60.00
            };
            Rectangle rectangle2 = new Rectangle()
            {
                Name = "Rectangle",
                Width = 20,
                Height = 30,
                Area = 600.00,
                Circumference = 100.00
            };
            Rectangle rectangle3 = new Rectangle()
            {
                Name = "Rectangle",
                Width = 40,
                Height = 50,
                Area = 2000.00,
                Circumference = 180.00
            };
            Console.WriteLine(circle1.CircleInfo());
            Console.WriteLine(circle2.CircleInfo());
            Console.WriteLine(circle3.CircleInfo());
            Console.WriteLine(rectangle1.RectangleInfo());
            Console.WriteLine(rectangle2.RectangleInfo());
            Console.WriteLine(rectangle3.RectangleInfo());

            Console.ReadKey();
        }
    }
    public abstract class Shape
    {
        public string Name { get; set; }
        public class Circle : Shape
        {
            public double Radius { get; set; }
            public double Area { get; set; }
            public double Circumference { get; set; }
            public string CircleInfo()
            {
                return $"Shape-Name: {Name} Radius={Radius} Area={Area} Circumference={Circumference}";
            }


        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public double Area { get; set; }
            public double Circumference { get; set; }
            public string RectangleInfo()
            {
                return $"Shape-Name: {Name} Width={Width} Height={Height} Area={Area} Circumference={Circumference}";
            }


        }
    }
}
