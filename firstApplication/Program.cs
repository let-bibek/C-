using System;

namespace firstApplication
{
    //Program to find area of Rectangle.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breadth:\n");
            //in procedural oriented approach
            // string len = Console.ReadLine();
            // string bre = Console.ReadLine();
            //double l = Convert.ToDouble(len);
            // double b = Convert.ToDouble(bre);
            double l = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            //double area = l * b;
            // Console.WriteLine("The are of rectangle is: " + (l*b);
            // Console.ReadKey();//end of pop
            Rectangle r = new Rectangle();
            r.SetData(l, b);
            double res = r.GetArea();
            Console.WriteLine("The area of rectangle is:\n " + res);
        }
    }
    class Rectangle
    {
        private double len, bre;
        public void SetData(double len, double bre)
        {
            this.len = len;
            this.bre = bre;
        }
       public double GetArea()
        {
            return (len * bre);
        }

    }
}
