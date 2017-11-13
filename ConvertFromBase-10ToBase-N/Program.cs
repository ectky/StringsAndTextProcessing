using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int base10 = int.Parse(input[1]);
            int n = int.Parse(input[0]);
            StringBuilder baseN = new StringBuilder();
            int num = base10;

            while (!(num == 0))
            {
                baseN.Append(num % n);
                num /= n;
            }

            StringBuilder sb2 = new StringBuilder();
            for (int i = baseN.Length - 1; i > -1; i--)
            {
                sb2.Append(baseN[i]);
            }
            Console.WriteLine(sb2);
        }
    }
}
