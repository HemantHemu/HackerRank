using System;

public static class PrimeTriplets
{
	 public void PrimeTriplet()
	{
        int[] rows = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int size = Math.Max(rows[0], rows[1])+1;
        int[] primeDict = new int[(size*(size+1))/2+1];
        int maxInp = primeDict.Length;
        primeDict[2] = 1;
        for (int i = 2; i < maxInp ; i++)
        {
            if (primeDict[i] != -1)
            {
                primeDict[i] = 1;
                for (int inc = 2, y = i * inc; y < maxInp ; inc++, y = i * inc)
                {
                    primeDict[y] = -1;
                }
            }
        }
    }
}
