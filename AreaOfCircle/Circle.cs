using System;
using System.Collections.Generic;
using System.Text;

namespace AreaOfCircle
{
    class Circle
    {
        public double radius;
        public double area;
        public double circumference;
        public double diameter;
        public Circle(double radius)
        {
            this.radius = radius;
            this.area = Math.PI * Math.Pow(radius, 2);
            this.circumference = Math.PI * 2 * radius;
            this.diameter = 2 * radius;
        }
    }
}
