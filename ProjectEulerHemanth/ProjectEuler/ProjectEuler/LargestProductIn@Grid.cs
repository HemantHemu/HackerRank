using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LargestProductIn_Grid
    {
        public static void TheMazeRunner()
        {
            int[][] maze = new int[20][];
            for(int i =0;i<20;i++) {
                maze[i] = Array.ConvertAll(Console.ReadLine().Trim().Split(' ').ToArray(), Convert.ToInt32);
            }
            Int64 product = 1, max = -1;
            
            for(int i = 0; i < 20; i++) {

                //horizontal window sliding
                product = maze[i][0] * maze[i][1] * maze[i][2] * maze[i][3];
                max = product > max ? product : max;
                for (int rowWindow = 0; rowWindow < 17; rowWindow++){
                    if (maze[i][rowWindow] != 0) { product /= maze[i][rowWindow]; product *= maze[i][rowWindow + 3];   }
                    else { product = 1; for(int recalc = 1; recalc < 5; recalc++) { product *= maze[i][rowWindow + recalc]; } }
                    max = product > max ? product : max;
                }

                //vertical window sliding
                product = maze[0][i] * maze[1][i] * maze[2][i] * maze[3][i];
                max = product > max ? product : max;
                for (int colWindow = 0; colWindow < 17; colWindow++)
                {
                    if (maze[colWindow][i] != 0) { product /= maze[colWindow][i]; product *= maze[colWindow+3][i]; }
                    else { product = 1; for (int recalc = 1; recalc < 5; recalc++) { product *= maze[colWindow + recalc][i]; } }
                    max = product > max ? product : max;
                }

                for(int row = 0; row < 17; row++) {
                    //diagonal window sliding -- principle diagonal
                    for (int col = 0; col < 17; col++) {
                        product = maze[row][col] * maze[row + 1][col + 1] * maze[row + 2][col + 2] * maze[row + 3][col + 3];
                        max = product > max ? product : max;
                    }
                    //diagonal window sliding -- other diagonal
                    for (int col = 3; col < 20; col++)
                    {
                        product = maze[row][col] * maze[row + 1][col - 1] * maze[row + 2][col - 2] * maze[row + 3][col - 3];
                        max = product > max ? product : max;
                    }
                }
            }

            Console.WriteLine(max);
        }
    }
}
