using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_using_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breadth");
            double l = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Rectangle r = new Rectangle();//creating object of Rectangle
            r.SetData(l, b);
            double result = r.GetArea();
            Console.WriteLine("The area of the rectangle is:" + result);
            Console.ReadKey();
        }

    }
    class Rectangle
    {
        private double len, bre;
        public void SetData(double len, double  bre)
        {
            this.len = len;
            this.bre = bre;
        }
        public double GetArea()
        {
            return len * bre;
        }
    }
}

