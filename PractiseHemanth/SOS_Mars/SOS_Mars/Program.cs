using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS_Mars
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            List<char> s_list = s.ToCharArray().ToList();
            int size = s_list.Count;
            int count = 0;
            for(int i =0;i<size;i+=3)
            {
                if((s_list[i]!='S'))
                {
                    count++;
                }
                if ((s_list[i+1] != 'S'))
                {
                    count++;
                }
                if ((s_list[i+2] != 'S'))
                {
                    count++;
                }
            }
            Console.WriteLine( count);
            Console.ReadKey();
        }
    }
}
