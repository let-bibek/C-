using System;
namespace Practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            //WAP  to check a number entered by a user is 
            //negative, positive or zero.[if-else-if ladder
            Console.WriteLine("Enter any number:\n");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0)
            {
                Console.WriteLine("The number is zero.");
                
            }
            else if (num1 > 0)
            {
                Console.WriteLine("The mumber is positive.");
                
            }
            else
            {
                Console.WriteLine("The number is negative");
                
            }
            Console.ReadKey();
        }
    }
}
