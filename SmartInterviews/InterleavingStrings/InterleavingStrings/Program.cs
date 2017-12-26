//success, but not sure about time constraint and memory also
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterleavingStrings
{
    class Program
    {
        public static List<string> Storage = new List<string> { };
        static void Main(string[] args) {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                Storage.Clear();
                string[] ss = Console.ReadLine().Split(' ');
                //bool greater = ss[0].Length >= ss[1].Length;
                //string s1 = greater ? ss[0] : ss[1];
                //string s2 = !greater ? ss[0] : ss[1];
                char[] chs2 = ss[1].ToCharArray();
                int countToRemove = 0, chs2Count = ss[1].Length;
                char current, previous;
                List<string> tempStorage = new List<string> { };
                Inserter(ss[0], chs2[0]);
                foreach (string g in Storage)
                {
                    tempStorage.Add(g);
                }
                for (int i = 1; i < chs2Count; i++)
                {
                    countToRemove = Storage.Count;
                    previous = chs2[i - 1];
                    current = chs2[i];
                    foreach (string s in tempStorage)
                    {
                        Inserter(s, current, previous);
                    }
                    //Storage.RemoveRange(0, countToRemove);
                    tempStorage.Clear();
                    int yy = Storage.Count;
                    for (int y = countToRemove;y< yy; y++)
                    {
                        tempStorage.Add(Storage[y]);
                    }
                }
                Console.WriteLine(string.Join(Environment.NewLine, Storage));
                t--;
            }
            Console.ReadKey();
        }
        static void Inserter(string inp,char ins,char prev) {
            int length = inp.Length;
            for (int i = inp.IndexOf(prev)+1; i <= length; i++)
            {
                string temp = inp;
                Storage.Add(temp.Insert(i, ins.ToString()));
            }
        }
        static void Inserter(string inp, char ins){
            int length = inp.Length;
            for (int i =0;i<=length;i++){
                string temp = inp;
                Storage.Add(temp.Insert(i, ins.ToString()));
            }
        }
    }
}
