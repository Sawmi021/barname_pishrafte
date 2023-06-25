using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program10
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }
        public Program10() { }
        public Program10(int X1, int Y1, int X2, int Y2)
        {
            x1 = X1;
            y1 = Y1;
            x2 = X2;
            y2 = Y2;
        }
        public double calc()
        {
            return Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            int num5 = Convert.ToInt32(Console.ReadLine());
            int num6 = Convert.ToInt32(Console.ReadLine());
            int num7 = Convert.ToInt32(Console.ReadLine());
            int num8 = Convert.ToInt32(Console.ReadLine());

            Program10 temp = new Program10(num1, num2, num3, num4);
            Program10 temp1 = new Program10(num5, num6, num7, num8);
            double res = temp.calc();
            double res1 = temp1.calc();
            if (res > res1)
            {
                Console.WriteLine("bozorgatr");

            }
            else
            {
                Console.WriteLine("koochiktar");
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}