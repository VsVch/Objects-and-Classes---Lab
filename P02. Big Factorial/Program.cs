using System;
using System.Numerics;

namespace P02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            BigInteger sum = 1;
            for (int i = 2; i <= num; i++)
            {
                sum *= i;
            }

            Console.WriteLine(sum);
        }
    }
}
