using System;

namespace _5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double v = 20.4 ;
            for (int a = 1; a < 21; a++) Console.WriteLine($"{a}\t{v * a}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
