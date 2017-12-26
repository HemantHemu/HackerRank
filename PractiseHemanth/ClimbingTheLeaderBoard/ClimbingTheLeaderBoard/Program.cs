// y==-1  idiot

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingTheLeaderBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] scores_temp = Console.ReadLine().Split(' ');
            int[] scores = Array.ConvertAll(scores_temp, Int32.Parse);
            int m = Convert.ToInt32(Console.ReadLine());
            string[] alice_temp = Console.ReadLine().Split(' ');
            int[] alice = Array.ConvertAll(alice_temp, Int32.Parse);
            // Write Your Code Here
            int[] dis = scores.Distinct().ToArray();
            int disLenght = dis.Length, y = 0, temp = disLenght - 1;
            for (int i = 0; i < m; i++)
            {
                for (y = temp; y >= 0; y--)
                {
                    if (alice[i] == dis[y]) { Console.WriteLine(y + 1); temp = y - 1; break; }
                    if (alice[i] < dis[y]) { Console.WriteLine(y + 2); temp = y; break; }
                }
                if (y == -1) { Console.WriteLine(1); }
                //Console.WriteLine("dsadasdasd");
            }
    }
}
