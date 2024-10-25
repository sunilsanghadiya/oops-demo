using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_demo
{
    #region Encapsulation Example
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double getArea()
        {
            return Length * Width;
        }

        public void Display()
        {
            Console.WriteLine("************** Encapsulation Example **************");
            Console.WriteLine("Length: {0}", Length);
            Console.WriteLine("Width: {0}", Width);
            Console.WriteLine("Area: {0}", getArea());
            Console.WriteLine("************** Completed Encapsulation Example **************");
        }

        public class ExecuteRectangle
        {
            static void Main(string[] args)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Length = 4.5;
                rectangle.Width = 3.5;
                rectangle.Display();
                Console.ReadLine();
            }
        }
    }
    #endregion Encapsulation Example
}
