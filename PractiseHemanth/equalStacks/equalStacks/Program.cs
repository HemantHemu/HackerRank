using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n1 = Console.ReadLine().Split(' ');
            int n1 = Convert.ToInt32(tokens_n1[0]);
            int n2 = Convert.ToInt32(tokens_n1[1]);
            int n3 = Convert.ToInt32(tokens_n1[2]);
            Stack<int> s1 = new Stack<int> { };
            Stack<int> s2 = new Stack<int> { };
            Stack<int> s3 = new Stack<int> { };
            string[] h1_temp = Console.ReadLine().Split(' ');
            string[] h2_temp = Console.ReadLine().Split(' ');
            string[] h3_temp = Console.ReadLine().Split(' ');
            s1.Push(int.Parse(h1_temp[n1 - 1]));
            for (int i = n1 - 2; i >= 0; i--)
            {
                s1.Push(int.Parse(h1_temp[i]) + s1.Peek());
            } 
            s2.Push(int.Parse(h2_temp[n2 - 1]));
            for (int i = n2 - 2; i >=0; i--)
            {
                //if (s1.Contains(int.Parse(h2_temp[i]) + s2.Peek()))
                { s2.Push(int.Parse(h2_temp[i]) + s2.Peek()); }
            }
            s3.Push(int.Parse(h3_temp[n3 - 1]));
            for (int i = n3 - 2; i >= 0; i--)
            {
                //if (s2.Contains(int.Parse(h3_temp[i]) + s3.Peek()))
                { s3.Push(int.Parse(h3_temp[i]) + s3.Peek()); }
            }
            int temp = 0;
            if((n1 > n2) && (n1 > n3))
            {
                while (true)
                {
                    if (s2.Contains(s1.Peek()) && s3.Contains(s1.Peek()))
                    { temp = s1.Pop(); break; }
                    s1.Pop();
                }
            }
            else if(n2 > n3)
            {
                while (true)
                {
                    if (s1.Contains(s2.Peek()) && s3.Contains(s2.Peek()))
                    { temp = s2.Pop(); break; }
                    s2.Pop();
                }
            }
            else
            {
                while (true)
                {
                    if (s2.Contains(s3.Peek()) && s1.Contains(s3.Peek()))
                    { temp = s3.Pop(); break; }
                    s3.Pop();
                }
            }
                Console.WriteLine(temp); 
            Console.ReadKey();

        }
    }
}
