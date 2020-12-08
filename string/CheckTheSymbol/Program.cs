using System;

namespace CheckTheSymbol
{
    class Program
    {
        public static void IsDigit()
        {
            Console.WriteLine("Input number or character");
            
            char value = Convert.ToChar(Console.ReadLine());
            bool result = char.IsDigit(value);

            Console.WriteLine(result ? "It is a number" : "It is a character");

        }
        static void Main(string[] args)
        {
            IsDigit();
        }
    }
}
