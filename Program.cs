using System;

namespace oran1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int lnko = LNKO(m, n);
            Console.WriteLine($"LNKO({m}, {n}) = {lnko}");
        }

        static int LNKO(int m, int n)
        {
            int r = m % n;
            while (r != 0)
            {
                m = n;
                n = r;
                r = m % n;
            }
            return n;
        }
    }
}
