using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, c;
            b = 7;
            c = 9;
            int great = b > c ? b : c;
            Console.WriteLine(great);
            Console.ReadKey();
        }
    }
}
