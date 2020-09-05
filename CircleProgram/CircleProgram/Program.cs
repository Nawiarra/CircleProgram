using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircleCore;
using PointCore;

namespace CircleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(new Point(0, 0), 12);
            Circle c2 = new Circle(new Point(3, 5), 11);

            if (Circle.IsAreaEquals(c1.CalculateArea(), c2.CalculateArea()))
            {
                Console.WriteLine("Is equals");
            }
            else
            {
                Console.WriteLine("Is not equals");
            }
            Console.ReadKey();

        }
    }
}
