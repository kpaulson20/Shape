using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Ellipse
    {
        //declarations
        private double _SemiMajor;
        private double _SemiMinor;
        private double DefaultSemiMajor = 0;
        private double DefaultSemiMinor = 0;
        public static int objectsAlive = 0;
        //private double onlySeenHere;
        public double Major { get; set; }
        public double Minor { get; set; }

        public Ellipse()
        {
            objectsAlive++;
            _SemiMinor = DefaultSemiMinor;
            _SemiMajor = DefaultSemiMajor;
            Console.WriteLine("An ellipse with a default semi minor axis of " + _SemiMinor + " and semi major axis of " + _SemiMajor + " was created");
        }
        //parameterized
        public Ellipse(double major, double minor)
        {
            objectsAlive++;
            _SemiMinor = minor;
            _SemiMajor = major;
            Console.WriteLine("An ellipse with a semi minor axis of " + _SemiMinor + " and semi major axis of " + _SemiMajor + " was created");
        }
        //copy
        public Ellipse(Ellipse e)
        {
            _SemiMajor = e.Major;
            _SemiMinor = e.Minor;
        }
        public double calcArea()
        {
            return Math.PI * (_SemiMajor * _SemiMinor);
        }
        public double calcPerimeter()
        {
            return Math.PI * (3 * (_SemiMajor + _SemiMinor)) - Math.Sqrt((3 * _SemiMajor) + _SemiMinor) * (_SemiMajor + (3 * _SemiMinor));
        }
    }
}
