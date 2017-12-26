using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueriesWithFixedLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ss = Console.ReadLine().Split();
            int n = int.Parse(ss[0]);
            int q = int.Parse(ss[1]);
            string[] ll = Console.ReadLine().Split();
            int[] arraySet = new int[n];
            arraySet = Array.ConvertAll(ll, Int32.Parse);
            int[] dd = new int[q];
            for(int i =0;i<q;i++)
            {
                dd[i] = int.Parse(Console.ReadLine());
            }
            int[] resultArray = new int[q];
            Queue<int> maxFinder = new Queue<int> { };
            int temp = 0;
            #region queue
            // find min(max(combinations)) using stacks or queues
            for (int i = 0; i < q; i++)
            {
                maxFinder.Clear();
                int j ;
                for (j = 0; j < dd[i]; j++)
                {
                    while (maxFinder.Any() && arraySet[i] >= arraySet[maxFinder.Last()])
                        maxFinder.Reverse();
                    maxFinder.Dequeue();
                    maxFinder.Reverse();

                    maxFinder.Enqueue(j);
                }
                for (; j < n; j++)
                {
                    // Remove the elements which are out of this window
                    while ((maxFinder.Any()) && maxFinder.First() <= i - dd[i])
                        maxFinder.Dequeue();

                    // Remove all elements smaller than the currently
                    // being added element (remove useless elements)
                    while ((maxFinder.Any()) && arraySet[i] >= arraySet[maxFinder.Last()])
                        maxFinder.Reverse();
                    maxFinder.Dequeue();
                    maxFinder.Reverse();


                    // Add current element at the rear of Qi
                    maxFinder.Enqueue(i);
                }

                //maxFinder.Dequeue();
                //maxFinder.Enqueue(arraySet[j]);
                //temp = maxFinder.Max();
                //if (temp < minFinder.Peek())
                //{
                //    minFinder.Dequeue();
                //    minFinder.Enqueue(temp);
                //}
                resultArray[i] = 0; //hfjhgvuifyuhuigv
            }
            #endregion


            #region regular array technique
            //regular array technique
            //int tempMin = 0;
            //int tempO = arraySet.Max();
            //int max = 0;
            //int current = 0;
            //int limit1 = 0;
            //int limit2 = 0;
            //for (int i = 0; i < q; i++)
            //{
            //    current = dd[i];
            //    tempMin = tempO;
            //    limit1 = n - current;
            //    for (int j = 0; j <= limit1; j++)
            //    {
            //        max = 0;
            //        limit2 = j + current;
            //        for (int k = j; k < limit2; k++)
            //        {
            //            //if (arraySet[k] > max) { max = arraySet[k]; }
            //            max = (arraySet[k] > max) ? arraySet[k] : max;
            //        }
            //        if (tempMin > max)
            //        { tempMin = max; }
            //    }
            //    resultArray[i] = tempMin;
            //}
            #endregion
            for (int i = 0;i<q;i++)
            {
                Console.WriteLine(resultArray[i]);
            }
            Console.ReadKey();
        }
    }
}
