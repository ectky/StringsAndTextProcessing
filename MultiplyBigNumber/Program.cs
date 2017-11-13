using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());
            string n2 = n1;

            int sum = 0;
            int rem = 0;
            int num = 0;
            StringBuilder sb = new StringBuilder();

            for (int j = 1; j < multiplyer; j++)
            {
                if (n1.Length > n2.Length)
                {
                    n2 = n2.PadLeft(n1.Length, '0');
                }
                else
                {
                    n1 = n1.PadLeft(n2.Length, '0');
                }
                sb = new StringBuilder();
                for (int i = n1.Length - 1; i >= 0; i--)
                {
                    sum = n1[i] - 48 + n2[i] - 48 + rem;
                    rem = sum / 10;
                    num = sum % 10;
                    sb.Append(num);
                }
                if (rem > 0)
                {
                    sb.Append(rem);
                }
                n1 = Reverse(sb.ToString()); rem = 0;
            }


            

            Console.WriteLine(Reverse(sb.ToString()).TrimStart('0'));
        }

        private static string Reverse(string sb)
        {
            StringBuilder sb2 = new StringBuilder();
            for (int i = sb.Length - 1; i > -1; i--)
            {
                sb2.Append(sb[i]);
            }
            return sb2.ToString();
        }
    }
}
