using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var rnd = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = rnd.Next(0, input.Length);

                var a = input[randomIndex];
                var b = input[i];

                input[randomIndex] = b;
                input[i] = a;


            }
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }



        }
    }
}
