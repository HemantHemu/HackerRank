// score is very less only 30.33

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longestCollatZseQuence
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] inp = new int[t];
            while (t>0) {
                --t;
                inp[t] = int.Parse(Console.ReadLine());
            }
            t = inp.Max();
            int inpMax = inp.Max();
            
            SortedDictionary<int, int> pairs = new SortedDictionary<int, int> { };
            while (t > 0) {
                if (!pairs.ContainsKey(t))
                {
                    int temp = t;
                    List<int> tempDict = new List<int> { };
                    tempDict.Add(temp);
                    temp = temp % 2 == 0 ? temp / 2 : temp * 3 + 1;
                    if (pairs.ContainsKey(temp)) { int val = 0; pairs.TryGetValue(t, out val); pairs.Add(t,val+1); continue; }
                        tempDict.Add(temp);
                    
                    while (temp != 1)
                    {
                        temp = temp % 2 == 0 ? temp / 2 : temp * 3 + 1;
                        tempDict.Add(temp);
                    }
                    
                    int length = tempDict.Count, i = length;
                    while (length > 1)
                    {
                        if (tempDict[length - 2]<=inpMax && !pairs.ContainsKey(tempDict[length - 2]))
                        {
                            pairs.Add(tempDict[length - 2], i - length + 1);
                        }
                        length--;
                    }
                }
                t--;
            }
            t = inp.Length;
            while(t>0)
                {
                --t;
                int max = 0,maxkey=0;
                
                    foreach (KeyValuePair<int, int> pp in pairs) {
                    if (pp.Key < inp[t] && pp.Value >= max) { max = pp.Value;maxkey = pp.Key; }
                    }
                Console.WriteLine(maxkey);
            }

        }
    }
}
