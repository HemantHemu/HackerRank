using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.Parse("{"));
            /*
            int t = Convert.ToInt32(Console.ReadLine());
            List<string> input = new List<string> { };
            for (int a0 = 0; a0 < t; a0++)
            {
                string expression = Console.ReadLine();
                input.Add(expression);
            }
            foreach(string ss in input)
            {
                if((ss.Length>=2)&&(ss.Length%2==0))
                {
                    bool flag = true;
                    List<char> first = ss.Substring(0, (ss.Length / 2) ).ToCharArray().ToList();
                    List<char> second = ss.Substring( (ss.Length / 2) , (ss.Length / 2)).ToCharArray().ToList();
                    for (int i = 0; i<ss.Length/2;i++)
                    {
                        if (!(first[i] == second[ ((ss.Length/2) - i - 1) ] ))
                            //u fool, they are not eqaul... get the ascii codes....
                        {
                            flag = false;
                            Console.WriteLine("No");
                            break;
                        }

                    }
                    if(flag)
                    { Console.WriteLine("Yes"); }
                }
                
                else
                {
                    Console.WriteLine("No");
                }
            }*/
            Console.ReadKey();
            
        }
    }
}
