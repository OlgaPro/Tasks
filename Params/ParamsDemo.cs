using System;

namespace Params
{
    class ParamsDemo
    {
        static void Main(string[] args)
        {
            Min obj = new Min();
            int min;
            int a = 10, b = 5;
            int[] mas = { 2, 4, 1, -5, 5 };
                
            min = obj.MinValue();
            Console.WriteLine("0 min = " + min);

            min = obj.MinValue(a, b);
            Console.WriteLine("a, b min = " + min);

            min = obj.MinValue(a, b, -1);
            Console.WriteLine("a, b, -1 min = " + min);

            min = obj.MinValue(mas);
            Console.WriteLine("mas min = " + min);
        }
    }
}
