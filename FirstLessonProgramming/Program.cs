using System;

namespace FirstLessonProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: a=");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: b=");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + " + " + b + " = " + Sum(a, b));
        }

        public static int Sum(int var1, int var2)
        {
            return var1 + var2;
        }
    }
}
