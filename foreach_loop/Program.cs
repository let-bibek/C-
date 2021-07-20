using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student = new string[] { "Prakash", "Ashok", "Aashish","Ram" };
            foreach(string names in student)
            {
                Console.WriteLine(names);
                
            }
            Console.ReadKey();
        }
    }
}
