using System;

namespace ReplaceSentence
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите предложение: ");
            Reverse(SplitText(Console.ReadLine()));
           
        }
        static string[] SplitText(string text)
        {
            string[] arrayForSplit = text.Split(" ");
            return arrayForSplit;
        }

        static void Reverse(string[] text)
        {
            string word;
            string newWord = null;
            for (int i = text.Length - 1; i > -1; i--)
            {
                word = text[i];
                newWord += word + " ";
            }
            Console.WriteLine(newWord);
        }
    }
}

