using System;

namespace MoveToTheOppositeRegister
{
    class Program
    {
        private static char changeRegister;

        public static void IsUpper()
        {
            Console.WriteLine("Write character in any register");
            char character = Convert.ToChar(Console.ReadLine());

            bool check = char.IsUpper(character);

            if (check)
            {
                changeRegister = char.ToLower(character);
                Console.WriteLine(changeRegister);
            }
            else
            {
                changeRegister = char.ToUpper(character);
                Console.WriteLine(changeRegister);
            }
        }
        static void Main(string[] args)
        {
            IsUpper();
        
        }
    }
}
