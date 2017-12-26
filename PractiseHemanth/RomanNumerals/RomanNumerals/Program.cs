//SOLVED ALL CASES 100/100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<string> inp = new List<string> { };
            for (int i = 0; i < t; i++)
            {
                inp.Add(Console.ReadLine());
            }

            int[] charValues = new int[200];
            charValues['M'] = 1000;
            charValues['D'] = 500;
            charValues['C'] = 100;
            charValues['L'] = 50;
            charValues['X'] = 10;
            charValues['V'] = 5;
            charValues['I'] = 1;

            //char chc = Convert.ToChar(98);

            foreach (string ss in inp)
            {
                int sum = 0;
                StringBuilder sb = new StringBuilder();
                char[] tempInp = ss.ToCharArray();

                foreach (char ch in tempInp)
                {
                    sum += charValues[ch];
                }
                int q = sum / 1000;
                if (q >= 1)
                {
                    sum = sum % (1000);
                    while (q > 0) { sb.Append('M'); q--; }
                }
                q = sum / 500;
                if (q == 1)
                {
                    if (sum >= 900) { sb.Append("CM"); sum = sum % 100; } // U DIDOT FOOL STUPIDASDASDASKFJDNASJKLFHDAUISDF
                    else
                    {
                        sb.Append('D');
                        sum = sum % 500;
                    }

                }
                q = sum / 100;
                if (q >= 1)
                {

                    if (q == 4) { sb.Append("CD"); }
                    else
                    {
                        while (q > 0) { sb.Append('C'); q--; }
                    }
                    sum = sum % (100);
                }
                q = sum / 50;
                if (q >= 1)
                {
                    if (sum >= 90) { sb.Append("XC"); sum = sum % (10); }
                    else
                    {
                        sb.Append('L');
                        sum = sum % (50);
                    }

                }
                q = sum / 10;
                if (q >= 1)
                {
                    sum = sum % (10);
                    if (q == 4) { sb.Append("XL"); }
                    else
                    {
                        while (q > 0) { sb.Append('X'); q--; }
                    }
                }
                q = sum / 5;
                if (q >= 1)
                {
                    if (sum == 9) { sb.Append("IX"); Console.WriteLine(sb.ToString()); continue; }
                    sum = sum % 5;
                    while (q > 0) { sb.Append('V'); q--; }
                }
                q = sum / 1;
                if (q >= 1)
                {

                    if (q == 4) { sb.Append("IV"); }
                    else
                    {
                        while (q > 0) { sb.Append('I'); q--; }
                    }
                }
                Console.WriteLine(sb.ToString());
            }
            Console.WriteLine("dsaasdasd");
        }
            
            
        }
}
