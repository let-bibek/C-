using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length and breadth:\n");
            string len = Console.ReadLine();
            string bre = Console.ReadLine();
            double l = Convert.ToDouble(len);
            double b = Convert.ToDouble(bre);
            double area = l * b;
            Console.WriteLine("The area is:" + area);
            Console.ReadKey();

        }
    }
}
