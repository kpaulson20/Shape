using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Pentagon
    {
        //declarations
        private double _side;
        private double _apothem;
        private double DefaultSide = 0;
        private double DefaultApothem = 0;
        public static int objectsAlive = 0;
        //private double onlySeenHere;
        public double Length { get; set; }
        public double Apothem { get; set; }

        public Pentagon()
        {
            objectsAlive++;
            _side = DefaultSide;
            _apothem = DefaultApothem;
            Console.WriteLine("A pentagon with default side length and apothem length of " + _side + " was created");
        }
        //parameterized
        public Pentagon(double side)
        {
            objectsAlive++;
            _side = side;
            Console.WriteLine("A pentagon with a side length of " + _side + " was created");
        }
        //copy
        public Pentagon(Pentagon p)
        {
            _side = p._side;
        }

        public double calcArea()
        {
            return (5 * _side * _apothem) / 2;
        }
        public double calcPerimeter()
        {
            return 5 * _side;
        }
    }
    
}
