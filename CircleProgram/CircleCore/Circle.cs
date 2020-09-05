using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointCore;

namespace CircleCore
{

    public class Circle
    {
        public Point Center { get; private set; }

        private double radius;
        public double Radius
        {
            get { return radius; }

            private set
            {
                radius = (value < 0) ? Math.Abs(value) : value;
            }
        }
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public static bool IsAreaEquals(double areaFirstEl, double areaSecondEl)
        {
            if (Math.Abs(areaFirstEl - areaSecondEl) < Double.Epsilon)
            {
                return true;
            }
            return false;
        }
    }
}
