using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            //if("Hi"=="hi")
            //{ Console.WriteLine("Yes"); }
            //else Console.WriteLine("No");
            Ransom rn = new Ransom();
            rn.check();
            Console.ReadKey();
        }
    }
    class Ransom
    {
        public void check()
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            List<string> magazine = Console.ReadLine().Split().ToList();
            List<string> ransomnote = Console.ReadLine().Split().ToList();
            bool flag = false;

            // --- lot of validations, m>n , count of words  ,  thats it
            //validations are done
            //test case 16 and 17 are getting timed out
            if (int.Parse(numbers[0]) >= int.Parse(numbers[1])) // >= added
            {
                foreach (string ss in ransomnote.Distinct())
                {
                    
                    if (!(magazine.Contains(ss)
                        &&  (ransomnote.Where(s=>s==ss).Count() <= magazine.Where(s => s == ss).Count()) ))
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                { Console.WriteLine("Yes"); }
                else { Console.WriteLine("No"); }
            }
            else Console.WriteLine("No");
        }
    }
}
