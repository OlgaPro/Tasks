using System;

namespace ToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write character in lower case");
            char lowerCase = Convert.ToChar(Console.ReadLine());

            var result = char.ToUpper(lowerCase);

            Console.WriteLine(result);
        }
    }
}
