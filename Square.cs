using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Shape
{
    internal class Square
    {
        //declarations
        private double sideLength;
        private double DefaultLength = 0;
        public static int objectsAlive = 0;
        //private double onlySeenHere;

        public double Length { get; set; }

        public Square()
        {
            objectsAlive++;
            sideLength = DefaultLength;
            Console.WriteLine("A square with default side length of " + sideLength + " was created");
        }
        //parameterized constructor
        public Square(double length)
        {
            objectsAlive++;
            sideLength = length;
            Console.WriteLine("A square with side length of " + length + " was created");
        }
        //copy constuctor
        public Square(Square s)
        {
            sideLength = s.Length;
        }
        //calculate area
        public double calcArea()
        {
            return sideLength * sideLength;
            Console.WriteLine("The area of a square with side length " + sideLength + " is "); //Square.calcArea());
        }
        //calulate perimeter
        public double calcPerimeter()
        {
            Console.WriteLine("The perimeter of a square with side lenght " + sideLength + " is ");
            return 4 * sideLength;
        }
    }
}
