using System;

namespace Rastojanje_kuca
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, s1, s2, t, d, raz;

            v1 = double.Parse(Console.ReadLine());
            v2 = double.Parse(Console.ReadLine());
            t = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());

            s1 = v1 * t;
            s2 = v2 * t;

            raz = (s2 + d) - s1;

            Console.WriteLine(Math.Round(raz, 2));

        }
    }
}
