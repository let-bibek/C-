using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        { 
           /* unsafe
            {
                int t = 7;
                int* v = t;

            }*/
            int x = 5;
            object a = 6;
            int y = (int)a + 5;
            object result = y;
            Console.WriteLine(result);
            bool entry = false;
           // float num = 102.3F;
            if (!entry)
            {
                Console.WriteLine("hey");
            }
            Console.WriteLine("Hey, mf.");
            Console.ReadKey();
        }
    }
}
