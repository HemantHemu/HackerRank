using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string a and then b");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Anagram an = new Anagram(a, b);
            an.unique();
            Console.ReadKey();
        }
    }
    class Anagram
    {
        string one, two;
        int com=0, diff_a=0, diff_b=0,total=0;
        public Anagram(string a, string b)
        {
            one = a;
            two = b;
        }
        public void unique()
        {
            List<char> a_list = one.ToCharArray().ToList();
            List<char> b_list = two.ToCharArray().ToList();
            List<char> a_diff = a_list.Distinct().Except(b_list.Distinct()).ToList();
            List<char> b_diff = b_list.Distinct().Except(a_list.Distinct()).ToList();
            List<char> commons = a_list.Distinct().Intersect(b_list.Distinct()).ToList();
            a_list.Where(a=>a=='c').Count();
            foreach (char ch in commons)
            {
                com += Math.Abs(a_list.Where(a => a == ch).Count() - b_list.Where(a => a == ch).Count());
            }
            foreach(char ch in a_diff)
            {
                diff_a += a_list.Where(a => a == ch).Count();
            }
            foreach (char ch in b_diff)
            {
                diff_b += b_list.Where(a => a == ch).Count();
            }
            Console.WriteLine(diff_a + diff_b + total);
        }
    }
}
