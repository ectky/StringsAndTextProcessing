using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase_NToBase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string baseN = input[1];
            int n = int.Parse(input[0]);
            double base10 = 0;

            StringBuilder sb2 = new StringBuilder();
            for (int i = baseN.Length - 1; i > -1; i--)
            {
                sb2.Append(baseN[i]);
            }

            for (int i = 0; i < sb2.Length; i++)
            {
                int m = int.Parse(sb2[i].ToString());
                base10 += m * Math.Pow(n, i);
            }

            Console.WriteLine(base10);
        }
    }
}
