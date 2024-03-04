using System;

namespace NextFibonacciSequence
{
    class FibonacciSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check whether or not ");
            int n = int.Parse(Console.ReadLine());
            if (IsFibonacci(n))
            {
                Console.WriteLine($"{n} is a Fibonacci number.");
                int i = 0;
                while (i < 3)
                {
                    i++;
                    n = NextFibonacciSequence(n);
                    Console.Write($"{n}, ");
                }

                Console.WriteLine($"are the next 3 Fibonacci numbers.");
            }
            else
            {
                Console.WriteLine($"{n} is not a Fibonacci number.");
            }
        }
        static bool IsFibonacci(int n)
        {
            return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
        }

        static bool IsPerfectSquare(int n)
        {
            int s = (int)Math.Sqrt(n);
            return s * s == n;
        }

        static int NextFibonacciSequence(int n)
        {
            double a = n * (1 + Math.Sqrt(5)) / 2.0;
            return (int)Math.Round(a);
        }
    }
}