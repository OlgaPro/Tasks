using System;

namespace Ksec
{
    class Program
    {
        static void Secunda()
        {
            int k = Convert.ToInt32(Console.ReadLine());

            int h = k / 3600;
            int m = (k-(h*3600))/60;
            int s = k - (h * 3600 + m * 60);

            Console.WriteLine($"In {k} secund, {h} hours {m} minutes and {s} secund ");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input sec:");
            Secunda();
        }
    }
}
