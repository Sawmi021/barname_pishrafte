using System;
namespace ConsoleApplication4
{
    class Program6
    {
        private static void calc(int x) 
        {
            Console.WriteLine((Math.Pow(x, 2) + (2 * x) - 4));
        }

        private static Double MYGRADE(Double a, Double b) 
        {
            Double res = ((a * 0.35) + (b * 0.65));
            return res;
        }
        private static void calc1(int x, int y)
        { 
            Console.WriteLine(Math.Sqrt(Math.Abs(x) + Math.Pow(y, 2)));
        }
        private static int calc2(int x, int y, int z)
        {
            int res = x * y * z;
            return res;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("enter first number");
            Double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter second number");
            Double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter x,y,x");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());
            Double res = MYGRADE(num1, num2);
            if (res >= 10)
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            calc(num3);
            calc1(num3, num4);
            Console.WriteLine(calc2(num3, num4, num5));

        }

    }
}