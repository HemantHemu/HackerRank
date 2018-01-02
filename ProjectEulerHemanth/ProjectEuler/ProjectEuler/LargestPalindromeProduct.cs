using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LargestPalindromeProduct
    {
        public static void LPP()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[] inp = new int[t];
            for (int a0 = 0; a0 < t; a0++)
            {
                inp[a0] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < t; i++) {
                int testCase = generatePalindrome(inp[i]/1000);
                if (testCase > inp[i]) { testCase = generatePalindrome(testCase / 1000 - 1); }
                    while (true) {
                        if (checkForDivisors(testCase)) { Console.WriteLine(testCase); break; }
                        else { testCase = generatePalindrome(testCase / 1000 -1); }
                    }
                
            }
            Console.ReadKey();

        }
        public static bool checkForDivisors(int testcase)
        {
            int decrementor = testcase % 2 == 1 ? 2 : 1;
            int start = (int)Math.Ceiling(Math.Sqrt(testcase));
            start += decrementor == 2 && start % 2 == 0 ? 1 : 0;
            while (start > 99) {
                if (testcase % start == 0 && (testcase / start).ToString().Length==3) { return true; }
                else { start--; }
            }

            return false;
        }
        public static int generatePalindrome(int n)
        {
            string a = n.ToString();
            a = a + string.Join("",a.Reverse());
            return int.Parse(a);
        }
    }
}
