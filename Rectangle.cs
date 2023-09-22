using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Rectangle
    {
        //declarations
        private double _height;
        private double _width;
        private double DefaultHeight = 0;
        private double DefaultWidth = 0;
        public static int objectsAlive = 0;

        private Rectangle _rectangle;
        private double onlySeenHere;

        //properties
        //public Color Color { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        //default constructor
        public Rectangle()
        {
            objectsAlive++;
            _height = DefaultHeight;
            _width = DefaultWidth;
            Console.WriteLine("A rectangle with default height " + _height + " and width " + _width + " was created");
        }
        //parameterized constructor
        public Rectangle(double height, double width)
        {
            objectsAlive++;
            _height = height;
            _width = width;
            Console.WriteLine("A rectangle with height " + _height + " and width " + _width + " was created");
        }
        //copy constuctor
        public Rectangle(Rectangle r)
        {
            _height = r.Height;
            _width = r.Width;
        }
        //deconstructor
        ~Rectangle()
        {
            objectsAlive--;
            onlySeenHere = 5;
            Console.WriteLine("Destroying Rectangle with height " + _height + " and width " + _width);
        }
        //calculate area
        public double calcArea()
        {
            return _height * _width;
        }
        //calulate perimeter
        public double calcPerimeter()
        {
            return (_height + _width) * 2;
        }
    }
}
