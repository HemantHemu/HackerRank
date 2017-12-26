using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Solution
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            List<string> contacts = new List<string> { };
            List<int> results = new List<int> { };
            while (n > 0)
            {
                string[] inps = Console.ReadLine().Split();
                switch(inps[0])
                {
                    case "add":
                        contacts.Add(inps[1]);
                        break;
                    case "find":
                        int l = inps[1].Length;
                        results.Add(contacts.Where(x => x.Substring(0,l)==inps[1]).Count());
                        break;
                }
                n--;
            }
            foreach(int nnn in results)
            {
                Console.WriteLine(nnn);
            }
            Console.ReadKey();
        }
    }
}
