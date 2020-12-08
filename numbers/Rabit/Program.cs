using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using System;

namespace Rabit
{
    class Program
    {
        private int n;
        private int m;
        
        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.WriteLine("Input number N and M");

            prog.Readdata();
            prog.Checkdata();
            prog.Rabits();
        }
        public void Readdata()
        {
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
        }
        public void Checkdata()
        {
            if (n < 1)
                Console.WriteLine("The number N has to be more or equeal 1");
        }

        public void Rabits()
        {
            int result = n % m;
            Console.WriteLine(result);
        }        
    }
}
