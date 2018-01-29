using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        // the following list uses a Dictionary<TKey, TValue>, roughly the generic equivalent
        // of the nongeneric Hashtables class, to count the frequencies of words in a given
        // piece of text. 
        static Dictionary<string, int> CountWords(string text)
        {
            Dictionary<string, int> frequencies;
            frequencies = new Dictionary<string, int>();

            string[] words = Regex.Split(text, @"\W+");

            foreach (string word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }

            return frequencies;
        }

         

        static void Main(string[] args)
        {
            string text = @"Do you like green eggs and ham?
                        I do not like them, Sam-I-am.
                        I do not like green eggs and ham.";

            Dictionary<string, int> frequencies = CountWords(text);
            foreach(KeyValuePair<string, int> entry in frequencies)
            {
                string word = entry.Key;
                int frequency = entry.Value;
                Console.WriteLine("{0}: {1}", word, frequency);
            }
        }
    }
}
