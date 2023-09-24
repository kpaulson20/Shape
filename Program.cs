using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "System";

            var def = new Rectangle();
            var rct = new Rectangle(3, 7);
            Console.WriteLine("Area = " + rct.calcArea() + "    Perimeter = " + rct.calcPerimeter());
            Console.WriteLine();

            var rct1 = new Rectangle(4, 8);
            Console.WriteLine("Area = " + rct1.calcArea() + "   Perimeter = " + rct1.calcPerimeter());
            Console.WriteLine();

            var def2 = new Square();
            var sqr = new Square(5);
            Console.WriteLine("Area = " + sqr.calcArea() + "   Perimeter = " + sqr.calcPerimeter());
            Console.WriteLine();

            var sqr1 = new Square(8);
            Console.WriteLine("Area = " + sqr1.calcArea() + "   Perimeter = " + sqr1.calcPerimeter());
            Console.WriteLine();

            var def3 = new Circle();
            var circ = new Circle(2);
            Console.WriteLine("Area = " + circ.calcArea() + "   Perimeter = " + circ.calcPerimeter());
            Console.WriteLine();

            var circ1 = new Circle(7);
            Console.WriteLine("Area = " + circ1.calcArea() + "   Perimeter = " + circ1.calcPerimeter());
            Console.WriteLine();

            var def4 = new Ellipse();
            var ellipse = new Ellipse(6, 2);
            Console.WriteLine("Area = " + ellipse.calcArea() + "   Perimeter = " + ellipse.calcPerimeter());
            Console.WriteLine();

            var ellipse1 = new Ellipse(4, 7);
            Console.WriteLine("Area = " + ellipse1.calcArea() + "   Perimeter = " + ellipse1.calcPerimeter());
            Console.WriteLine();

            var def5 = new Pentagon();
            var pent = new Pentagon(4);
            Console.WriteLine("Area = " + pent.calcArea() + "   Perimeter = " + pent.calcPerimeter());
            Console.WriteLine();

            var pent1 = new Pentagon(6);
            Console.WriteLine("Area = " + pent1.calcArea() + "   Perimeter = " + pent1.calcPerimeter());
            Console.WriteLine();
        }
    }
}
