using System;
namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student_name = new string[5];
            for(int i = 0; i < 5; i++)
            {
                student_name[i] = Console.ReadLine();
            }
            foreach(string stu in student_name)
            {
                Console.WriteLine(stu);
            }
            Console.ReadKey();
        }
    }
}
