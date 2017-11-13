using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = { ' ', ',', '.', '!', '?' };
            string[] text = Console.ReadLine()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            List<string> polindromes = new List<string>();
            
            foreach (var word in text)
            {
                if (isPolindrome(word))
                {
                    polindromes.Add(word);
                }
                
            }

            Console.WriteLine(string.Join(", ", polindromes.Distinct().OrderBy(s => s)));
        }

        private static bool isPolindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (!(word[i] == word[word.Length - 1 - i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
