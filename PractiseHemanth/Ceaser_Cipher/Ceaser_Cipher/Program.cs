//solved all cases, stupid.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceaser_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int k = Convert.ToInt32(Console.ReadLine());
            k = k % 26;
            for(int i =0;i<n;i++){
                char temp = s[i];
                if (temp >= 65 && temp <= 90)
                {
                    sb.Append((temp + k) > 90 ? (char)((temp + k - 26)) : (char)((temp + k)));
                }
                else if (temp >= 97 && temp <= 122) {
                    sb.Append((temp + k) > 122 ? (char)((temp + k - 26)) : (char)((temp + k)));
                }
                else{
                    sb.Append(temp);
                }
               }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
