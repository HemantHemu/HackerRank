using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoBitSets
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int r1 = (1 + (int)Math.Ceiling(Math.Sqrt(1 + 8 * n))) / 2;
            int r2 = ((int)Math.Ceiling(Math.Sqrt(1 + 8 * n))-1) / 2;
            //checking purpose
            int ncr1 = (r1 * (r1 - 1)) / 2,ncr2 = (r2 * (r2 - 1)) / 2;
            StringBuilder ans = new StringBuilder();

            if(n == ncr1){
                ans.Append("11");
                while (r1 - 2 > 0) { ans.Append("0");--r1; }
            }
            //else if (n == ncr2)
            //{
            //    ans.Append("11");
            //    while (r2 - 2 > 0) { ans.Append("0"); --r2; }
            //}
            else if (n < ncr1 && n > ncr2){
                ans.Append("1");
                while (r1 - 1 > 0) { ans.Append("0"); --r1; }
                ans.Replace("0","1", ans.Length - n + r2 - 1,1);
            }
            else{
                Console.WriteLine("wrong logic stupid");
            }
            Console.WriteLine(ans);
            Console.ReadKey();
        }
         
    }
}




//static void Main(string[] args)
//{
//    int dd = short.MaxValue - 1;
//    decimal[] Dict = new decimal[dd];
//    Console.WriteLine(1<<32767);
//    //int check = Dict.Length
//    int check = Dict.Length, counter = 0;
//    for (int t = 1; ; t++)
//    {
//        decimal bnum = 1 << t;
//        for (int i = 0; i < t; i++)
//        {
//            decimal snum = 1 << i;
//            if (counter < check) { Dict[counter] = bnum + snum; ++counter; } else { break; }
//        }
//        if(counter >= check) { break; }
//    }
//    for (int y =0;y<100;y++){
//        Console.WriteLine(y+"-------"+Dict[y]);
//    }
//    Console.ReadKey();
//}
