using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sb = Console.ReadLine();
            StringBuilder sb2 = new StringBuilder();
            for (int i = sb.Length - 1; i > -1; i--)
            {
                sb2.Append(sb[i]);
            }
            Console.WriteLine(sb2);
        }
    }
}
