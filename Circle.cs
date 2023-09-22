using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle
    {
        //declarations
        private double _radius;
        private double DefaultRadius = 0;
        public static int objectsAlive = 0;
        private double onlySeenHere;

        public double Radius { get; set; }

        public Circle()
        {
            objectsAlive++;
            _radius = DefaultRadius;
            Console.WriteLine("A square with default radius of " + _radius + " was created");
        }
        //parameterized constructor
        public Circle(double radius)
        {
            objectsAlive++;
            _radius = radius;
            Console.WriteLine("A circle with a radius of " + radius + " was created");
        }
        //copy constuctor
        public Circle(Circle c)
        {
            _radius = c.Radius;
        }
        //deconstructor
        ~Circle()
        {
            objectsAlive--;
            onlySeenHere = 5;
            Console.WriteLine("Destroying circle with a radius of " + _radius);
        }
        //calculate area
        public double calcArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
        //calulate perimeter
        public double calcPerimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
