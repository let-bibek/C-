
using System;
namespace DemoNamespace44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dimension One:\n");
            double dim1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter dimension two:\n");
            double dim2 = Convert.ToDouble(Console.ReadLine());
            Triangle.Area a = new Triangle.Area();
            a.areaOfTraingle(dim1, dim2);
            Rectangle.Area b = new Rectangle.Area();
            b.areaOfRectangle(dim1, dim2);
            Console.ReadKey();
        }
    }

    namespace Triangle
    {
        class Area
        {
            public void areaOfTraingle(double dim1, double dim2)
            {
                double a = (1 / 2.0) * (dim1 * dim2);
                Console.WriteLine("The area of triangle is: " + a+" unit sq.");
            }
        };
    }
    namespace Rectangle
    {
        class Area
        {
            public void areaOfRectangle(double dim1, double dim2)
            {
                double ar = (dim1 * dim2);
                Console.WriteLine("The area of rectangle is: " + ar + " unit sq.");
            }
        };
    }
}
