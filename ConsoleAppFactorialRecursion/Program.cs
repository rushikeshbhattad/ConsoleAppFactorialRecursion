using System;

namespace FactorialRecursion
{
    class Fact
    {
        internal int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of given number is: " + new Fact().Factorial(n));
            Console.ReadKey();
        }
    }
}