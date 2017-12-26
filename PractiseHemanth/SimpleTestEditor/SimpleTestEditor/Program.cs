using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());
            Stack<int> ops = new Stack<int> { };
            Stack<string> editor = new Stack<string> { };
            List<string> output = new List<string> { };
            StringBuilder currentString = new StringBuilder();
            for(int i =0;i<q;i++)
            {
                string[] inps = Console.ReadLine().Split().ToArray();
                int k = int.Parse(inps[0]);
                string inpTemp = "";
                if (inps.Length>1) { inpTemp = inps[1]; }
                switch (k)
                {
                    case 1:
                        ops.Push(1);
                        editor.Push(inpTemp);
                        currentString.Append(inpTemp);
                        break;
                    case 2:
                        ops.Push(0);
                        int delete = int.Parse(inpTemp);
                        editor.Push(currentString.ToString().Substring(currentString.Length  - delete));
                        currentString.Remove(currentString.Length - delete, delete);
                        break;
                    case 3:
                        int printAt = int.Parse(inpTemp);
                        output.Add(currentString.ToString().ElementAt(printAt - 1).ToString());
                        break;
                    case 4:
                        string temp = editor.Pop();
                        if (ops.Peek()==1)
                        {
                            ops.Pop();
                            currentString.Remove(currentString.Length  - temp.Length, temp.Length);
                        }
                       else if (ops.Peek() == 0)
                        {
                            ops.Pop();
                            currentString.Append(temp);
                        }
                        break;
                }
                
            }
            foreach(string ss in output)
            { Console.WriteLine(ss); }
            Console.ReadKey();
        }
    }
}
