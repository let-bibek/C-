using System;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch demonstration
            Console.WriteLine("Enter the option 1-5");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Exit");
            int choice = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt16(Console.ReadLine());
            float result=0;
            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result = num1 / num2;
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter only option 1-5");
                    break;
            }
            Console.WriteLine("Result=" + result);
            Console.ReadKey();
        }

    }
}
