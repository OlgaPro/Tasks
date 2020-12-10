using System;
using System.Linq;

namespace Mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.InputMass6();
        }

        public void InputMass3()
        {
            Console.WriteLine("Input the dimension of the array N");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the numbers of the array N");
            var number = Console.ReadLine();
            var numbers = number.Split(' ').Select(Int32.Parse).ToArray();

            for (int i = 0; i < N; i++)
            {
                int k = i % 2;

                if (k == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }

        public void InputMass1()
        {
            Console.WriteLine("Input the dimension of the array N");
            int N = int.Parse(Console.ReadLine());

            if (N < 1 || N > 100) Console.WriteLine("Input N as 1≤N≤100");

            int[] array = new int[N];

            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(32);
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("----------------------------------------");

            foreach (int el in array)
            {
                int k = el % 2;

                if (k == 0)
                {
                    Console.WriteLine(el);
                }
            }
        }

        public void InputMass2()
        {
            Console.WriteLine("Input the dimension of the array N");
            int N = int.Parse(Console.ReadLine());

            if (N < 1 || N > 100) Console.WriteLine("Input N as 1≤N≤100");

            Console.WriteLine("Input N numbers");
            var sNumbers = Console.ReadLine();
            var numbers = sNumbers.Split(',').Select(Int32.Parse).ToList();

            int count = 0;
            foreach (int k in numbers)
            {
                if (k < 0)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine(count);
        }

        public void InputMass4()
        {
            Console.WriteLine("Input the dimension of the array N");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the numbers of the array N");
            var number = Console.ReadLine();
            var numbers = number.Split(' ').Select(Int32.Parse).ToArray();

            int count = 0;
            for (int i = 0; i < N-1; i++)
            {
                if (numbers[i + 1] > numbers[i])
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);
        }

        public void InputMass5()
        {
            Console.WriteLine("Input the dimension of the array N");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the numbers of the array N");
            var number = Console.ReadLine();
            var numbers = number.Split(' ').Select(Int32.Parse).ToArray();

            for (int i = 0; i < N - 1; i++)
            {
                if (numbers[i + 1] > 0 && numbers[i] > 0)
                {
                    Console.Write("YES");
                    break;
                }
                else if (numbers[i + 1] < 0 && numbers[i] < 0)
                {
                    Console.Write("YES");
                    break;
                }
                else
                { 
                    Console.Write("NO");
                }
            }
        }

        public void InputMass6()
        {
            Console.WriteLine("Input the dimension of the array N");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the numbers of the array N");
            var number = Console.ReadLine();
            var numbers = number.Split(' ').Select(Int32.Parse).ToArray();

            for (int i = 0; i <= N - 3; i++)
            {
                if(numbers[i] == numbers[i + 1] && numbers[i] == numbers[i + 2])
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
