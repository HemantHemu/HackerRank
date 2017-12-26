using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] scores_temp = Console.ReadLine().Split(' ');
        int[] scores = Array.ConvertAll(scores_temp, Int32.Parse);
        int m = Convert.ToInt32(Console.ReadLine());
        string[] alice_temp = Console.ReadLine().Split(' ');
        int[] alice = Array.ConvertAll(alice_temp, Int32.Parse);
        // your code goes here
        List<int> scorecard = scores.Distinct().ToList();
        List<int> ali_scores = alice.ToList();
        List<int> ali_rank = new List<int> { };
        foreach(int a in ali_scores)
        {
            int rank = scorecard.TakeWhile(x => x >= a).Count();
            ali_rank.Add(!scorecard.Contains(a)||rank==0?rank+1:rank);
        }
        foreach(int i in ali_rank)
        {

            Console.WriteLine(i);
        }
        Console.ReadKey();
    }
}
