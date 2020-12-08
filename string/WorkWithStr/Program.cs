using System;

namespace WorkWithStr
{
    class Program
    {
        public void Count()
        {


        }
            static void Main(string[] args)
        {
            Program count = new Program();
            count.Count();
        }

        public void CountWordsInTheSentence()
        {
            string str = Console.ReadLine();
            string[] words = str.Split(" ");
            Console.WriteLine("All words are " + words.Length);
        }
        public void TheBiggestWordTheSentence()
        {
            string str = Console.ReadLine();
            string[] words = str.Split(" ");
            string var = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > var.Length)
                {
                    var = words[i];
                }
            }
            Console.WriteLine("The biggest word in the sentence is" + var);
        }
        public void WordPolinom()
        {
            //char[] wordsPolinom = new char[4] { 'a', 'b', 'b', 'a' };

            string word = Console.ReadLine();
            int a = word.Length;

            int j = 0;
            do
            {
                bool comparing = word[(word.Length - 1) - j] == word[j];
                Console.WriteLine(comparing);
                j++;
            }
            while (j < word.Length);
        }
        public void FindTwoSimilarChar()
        {
            string s1 = Console.ReadLine();
            char[] arrS1 = s1.ToCharArray();

            for (int i = 0; i < arrS1.Length; i++)
            {
                for (int j = 1; j < arrS1.Length; j++)
                {
                    if (arrS1[i] == arrS1[j] && i != j)
                    {
                        Console.WriteLine(arrS1[i]);
                        return;
                    }
                }
            }
        }
        public void Contain()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            bool contatin = str1.Contains(str2);
            Console.WriteLine(contatin);
        }
    }
}
