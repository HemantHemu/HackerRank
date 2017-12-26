using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingFootball
{
    class Program
    {
        public static LinkedList<footBall> test = new LinkedList<footBall> { };
        static int shifted = 0;
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] inp = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int  current = 0, previous = 0, temp = 0;

            for (int i = 0; i < n; i++)
            {
                previous = current;
                current = inp[i];
                placeHolderIncrementor(current);
            }
            Console.ReadKey();
        }



        public static void placeHolderIncrementor(int current)
        {
            int temp = 0;
            if (test.Count == 0)
            {
                temp = current;
                while (temp >= 0) { test.AddFirst(new footBall()); --temp; }
                test.ElementAt(current).increment();
            }
            else if (test.Count < current + shifted + 1)
            {
                temp = current + shifted + 1 - test.Count;
                while (temp > 0) { test.AddLast(new footBall()); --temp; }
                var it = test.ElementAt(current + shifted);
                it.increment();
            }
            else if (test.Count > current + shifted)
            {
                var itpos = current + shifted;
                mainInc(itpos);
            }

            return;
        }
        public static void mainInc(int current)
        {
            //worl on it
            var itpos = current ;
            int currentVal = test.ElementAt(itpos).count, rightVal=0, leftVal=0;
            if (test.ElementAt(itpos).count == 0) { test.ElementAt(itpos).increment(); }

            else if (test.Count == itpos) { test.AddLast(new footBall()); test.Last().increment(); }

            else if (0 == itpos) { test.AddFirst(new footBall()); test.First().increment(); ++shifted; }
            //return 1; }
            else if ((rightVal = test.ElementAt(itpos + 1).count) == 0) { test.ElementAt(itpos + 1).increment(); }

            else if ((leftVal = test.ElementAt(itpos - 1).count) == 0) { test.ElementAt(itpos - 1).increment(); }
            
            else if (rightVal == leftVal && rightVal == currentVal) { test.ElementAt(itpos).increment(); }

            else if (leftVal - currentVal == 1 && leftVal - rightVal == 1) { test.ElementAt(itpos + 1).increment(); }

            else if (rightVal - currentVal == 1 && rightVal - leftVal == 1) { test.ElementAt(itpos - 1).increment(); }
            //all the above cases are base cases

            else if (leftVal > rightVal) { mainInc(itpos + 1); }

            else if (rightVal > leftVal) { mainInc(itpos - 1); }



            return ;
        }
    }
    public class footBall
    {
        public void increment() { ++count; }

        public int count { get; set; }
        
    }
}
