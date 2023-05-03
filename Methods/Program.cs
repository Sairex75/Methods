using System;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            RecieveWords(SplitText(Console.ReadLine()));
        }
        static string[] SplitText(string text)
        {
            string[] arrayForSplit = text.Split(" ");
            return arrayForSplit;
        }

        static void RecieveWords(string[] printWords)
        {
            foreach (string v in printWords)
            {
                Console.WriteLine(v);
            }
        }
    }
}
