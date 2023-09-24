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
        private double DefaultSide = 0;
        public static int objectsAlive = 0;
        //private double onlySeenHere;
        public double Length { get; set; }
        public double Apothem { get; set; }

        public Pentagon()
        {
            objectsAlive++;
            _side = DefaultSide;
            Console.WriteLine("A pentagon with default side length of " + _side + " was created");
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
            return 0.25 * Math.Sqrt(5 * (5 + 2*Math.Sqrt(5))) * Math.Pow(_side, 2);
        }
        public double calcPerimeter()
        {
            return 5 * _side;
        }
    }
    
}
