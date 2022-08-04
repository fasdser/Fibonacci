using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(5));
            Console.ReadKey();
        }

        public static int Fib(int n)
        {
            return n > 1 ? Fib(n - 1) + Fib(n - 2) : n;
        }

        public static int fib1(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;
            }

            return a;
        }

        public static int fib2(int n)
        {
            return n < 3 ? 1 : fib2(n - 1) + fib2(n - 2);
        }

        public static int fib3(int n)
        {
            return f(0, 1, n);
        }

        public static int f(int x, int y, int n)
        {
            if (n == 0)
                return x;
            else if (n == 1)
                return y;
            else if (n == 2)
                return x + y;
            else
                return f(y, x + y, n - 1);
        }

        const double goldenRatio = 1.61803398874989484820458683436d;

        // Binet formula
        public static int Fib4(int n) =>
          (int)Math.Round((Math.Pow(goldenRatio, n) - Math.Pow(-1 / goldenRatio, n)) / Math.Sqrt(5));

        public static int Fib5(int n)
        {
            double a = Math.Pow((1 + Math.Sqrt(5)) / 2, n);
            double b = Math.Pow((1 - Math.Sqrt(5)) / 2, n);
            double fn = (a - b) / Math.Sqrt(5);
            return (int)Math.Round(fn, 0);
        }
    }
}
