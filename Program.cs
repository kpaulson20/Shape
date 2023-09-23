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

            //var def = new Rectangle();
            var rct = new Rectangle(3, 7);
            //var rct1 = new Rectangle(4, 8);
            //var diffRectangle = new Rectangle(5, 4);

            //var def2 = new Square();
            var sqr = new Square(5);
            //var sqr1 = new Square(8);
            //var diffSquare = new Square(3);

            //var def3 = new Circle();
            var circ = new Circle(2);
            //var circ1 = new Circle(7);
            //var diffCircle = new Circle(9);

            //var def4 = new Ellipse(3, 5);
            var ellipse = new Ellipse(2, 6);
            //var ellipse1 = new Ellipse(4, 7);
            //var diffEllipse = new Ellipse(5, 9);

            //var def5 = new Pentagon();
            var pent = new Pentagon(4);
            //var pent1 = new Pentagon(6);
            //var diffPentagon = new Pentagon(3);
        }
    }
}
