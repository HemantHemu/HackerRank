using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiyaandStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            int length = inp.Length;
            string original = inp[0].ToString();
            bool misc = length % 2 == 0;
            bool left = true;
            for (int i =1;i<length;i++)
            {
                if(misc)
                {
                    misc = false;
                    original = original + inp[i];
                }
                else
                {
                    if(left)
                    {
                        left = !left;
                        original = inp[i] + original;
                    }
                    else if (!left)
                    {
                        left = !left;
                        original = original + inp[i];
                    }
                }

            }
            //foreach(char ch in original)
            //{
            //    Console.WriteLine(ch);
            //}
            Console.WriteLine(original);
            Console.ReadLine();
        }
    }
}
