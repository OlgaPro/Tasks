using System;

namespace Sum1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number from 1 to 100 for count the");
            SumN();
        }
        static void SumN()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int summa = ((1 + N) * N) / 2;

            Console.WriteLine(summa);
        }
    }
}
