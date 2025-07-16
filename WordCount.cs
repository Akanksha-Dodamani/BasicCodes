using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCodes
{
    public class WordCount
    {
        public static void NumberOfWords()
        {
            string sentence;

            Console.Write("Enter a sentence: ");
            sentence = Console.ReadLine();

            string[] words = sentence.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);


            Console.Write($"Number of words in given sentence are: {words.Length}");
        }
    }
}
