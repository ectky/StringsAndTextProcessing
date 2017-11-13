using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string s1 = input[0];
            string s2 = input[1];
            Console.WriteLine(AreExchangable(s1, s2).ToString().ToLower());
        }

        private static bool AreExchangable(string s1, string s2)
        {
            int chs = GetChars(s1);
            int chs2 = GetChars(s2);
            return chs == chs2;
        }

        private static int GetChars(string s1)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();
            foreach (var ch in s1)
            {
                if (!chars.ContainsKey(ch))
                {
                    chars.Add(ch, 0);
                }
                chars[ch] += 1;
            }

            return chars.Count();
        }
    }
}
