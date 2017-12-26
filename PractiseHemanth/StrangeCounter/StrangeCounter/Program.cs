using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        Int64 t = Convert.ToInt64(Console.ReadLine());
        Int64 quo = t / 3;
        Int64 bal_mod = t % 3;
        Int64 two_series = 0, counter_three = 0;
        if (t < 3) { Console.WriteLine(3 - t + 1); return; }
        for (int i = 0; ; i++)
        {
            Int64 power = (Int64)Math.Pow(2, i);
            if ((two_series + power) <= quo)
            { two_series += power; }
            else
            {
                counter_three = (Int64)Math.Pow(2, i - 1) * 3;
                break;
            }
        }
        Console.WriteLine((bal_mod != 0 || (quo - two_series) > 0) ? counter_three * 2 - bal_mod + 1 - (quo - two_series) * 3 : 1);
        //Console.ReadKey();

    }
}
