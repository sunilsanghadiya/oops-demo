using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_demo
{
    #region Polymorphisam Example
    public class Polymorphisam
    {
        public class Drawing
        {
            public virtual double Area()
            {
                return 0;
            }
        }

        public class Circle : Drawing
        {
            public double Redius { get; set; }
            public Circle()
            {
                Redius = 5;
            }
            public override double Area()
            {
                return 3.14 * Math.Pow(Redius, 2);
            }
        }

        public class MyRectangle : Drawing
        {
            public double Height { get; set; }
            public double Width { get; set; }

            public MyRectangle()
            {
                Height = 5.3;
                Width = 3.4;
            }
            public override double Area()
            {
                return Height * Width;
            }
        }
        static void Main(string[] args)
        {
            Drawing circle = new Circle();
            Console.WriteLine("Area: " + circle.Area());

            Drawing square = new MyRectangle();
            Console.WriteLine("Area: " + square.Area());

            Console.ReadLine();
        }
    }
    #endregion
}
