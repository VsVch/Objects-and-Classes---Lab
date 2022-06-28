using System;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var words = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                var randomIndex = rnd.Next(0, words.Length);


                var a = words[randomIndex];
                var b = words[i];

                words[randomIndex] = b;
                words[i] = a;
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
