using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class GameOfLetters
    {
        public static void GameOfThrones()
        {
            int t = int.Parse(Console.ReadLine());
            string[] inp = new string[t];
            for (int i = 0; i < t; i++) {
                inp[i] = Console.ReadLine();
            }


            for (int i = 0; i < t; i++) {
                string input = inp[i];
                int length = input.Length;
                char[] inpchar = input.ToCharArray();
                int[] countArray = new int[26];
                foreach(char ch in inpchar){
                    countArray[ch - 97]++;
                }
            }



        }
    }
}
