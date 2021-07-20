using System;

namespace even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int number=0;
            Console.WriteLine("Using while loop:\n");
            for (int i=1; i <= 200; i++)
             {
                 //usiing for loop
                 if (i % 2 == 0)
                 {
                     number++;
                 }
                 Console.WriteLine(number);


             }*/
             
            //using while loop
            Console.WriteLine("Using while loop:\n");
            int n = 0;
            while (n <= 200)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                    Console.ReadKey();

                }
                n++;

            }
            /*
            //using do while
            int n2=0;
            do
            {

                    Console.WriteLine(n2);

                n2 = n2 + 2;
                Console.ReadKey();
            }
            while (n2<=200);
            */
        }
    }
}
