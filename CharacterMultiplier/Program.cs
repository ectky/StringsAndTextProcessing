using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string s1 = input[0];
            string s2 = input[1];
            int n = 0;

            if (s1.Length < s2.Length)
            {
                string helper = s1;
                s1 = s2;
                s2 = helper;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                int p1 = s1[i];
                int p2 = s2[i];
                n += p1 * p2;
            }

            if (s1.Length > s2.Length)
            {
                for (int i = s2.Length; i < s1.Length; i++)
                {
                    n += s1[i];
                }
            }

            Console.WriteLine(n);
        }
    }
}
