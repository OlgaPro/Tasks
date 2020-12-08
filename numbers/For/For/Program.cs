using System;

namespace For
{
    class Program
    {
        public void Output()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int[] array = new int[b];

            for (int i = 0; a <= b; a++, i++) 
                array[i] = a;
            //Console.WriteLine(array);

            for (int k = 0; k < array.Length -1; k++)
            {
                int a2 = array[k] * array[k];
                for (int j = 0; j < array.Length -1; j++)
                {
                    if (array[j] == a2)
                    {
                        Console.WriteLine(array[j]);
                    }
                }
            }
            

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Output();
        }

        public void OutputEvenNumbers()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (; a <= b; a++)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
            }
        }
        public void OutputResidue()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (; a <= b; a++)
            {
                if (a % d == c)
                {
                    Console.WriteLine(a);
                }
            }

        }
    }
}
